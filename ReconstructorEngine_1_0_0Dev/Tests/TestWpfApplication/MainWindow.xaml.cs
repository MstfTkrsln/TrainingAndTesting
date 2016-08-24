using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.ServiceModel.Channels;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Interpress.ApplicationLayer.Components.WInterComponents.CommonElements.Extensions;
using Interpress.Entities.Arsiv;
using Interpress.Entities.Arsiv.Report;
using Interpress.Library.Libraries.DbtLibrary;
using Interpress.Library.Libraries.DbtLibrary.Imaging;
using Interpress.Library.Libraries.Proxy.Arsiv;
using Interpress.Library.ReconstructorEngine;
using Interpress.Library.ReconstructorEngine.InElements;
using Interpress.Library.ReconstructorEngine.OutElements;
using Interpress.Messages.Base;
using Telerik.Windows.Controls.Map.WPFBingSearchService;
using Telerik.Windows.Controls.TimeBar;
using Brush = System.Drawing.Brush;
using Brushes = System.Drawing.Brushes;
using Color = System.Drawing.Color;
using FilterExpression = Interpress.Messages.Base.FilterExpression;
using Image = Interpress.Library.Libraries.DbtLibrary.Image.Image;
using Matrix = System.Drawing.Drawing2D.Matrix;
using Pen = System.Drawing.Pen;
using PixelFormat = System.Drawing.Imaging.PixelFormat;
using Rectangle = System.Drawing.Rectangle;



namespace TestWpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Bitmap CreateFirstPageBitmap()
        {

                Bitmap firstBitmap = new Bitmap(Utils.ConvertMMtoPixel(190, 72), Utils.ConvertMMtoPixel(268, 72),PixelFormat.Format24bppRgb);

            
                Graphics grp = Graphics.FromImage(firstBitmap);
                //Doing white on the background
                 grp.FillRegion(Brushes.White,new Region(new Rectangle(0,0,firstBitmap.Width,firstBitmap.Height)));

                grp.Dispose();
                return firstBitmap;
        }

        void StartEngine(IList<InPage> pages)
        {
            ReEngine engine = new ReEngine(pages);


            while (engine.CanNextProcess())
            {
                IList<OutPage> output = engine.Process();

                Show(output);

            }
        }


        private void Show(IList<Interpress.Library.ReconstructorEngine.OutElements.OutPage> output)
        {
            MyImaging myImg = new MyImaging();
            int s = 1;


            foreach (OutPage outPage in output)
            {
                Bitmap firstBitmap = CreateFirstPageBitmap();

                foreach (OutImage outImage in outPage.Images)
                {
                    using ( Graphics g = Graphics.FromImage(firstBitmap))
                    {
                        g.DrawImage(
                        outImage.Img,
                        new Rectangle((int)outImage.LocationPixel.X, (int)outImage.LocationPixel.Y, outImage.Img.Width, outImage.Img.Height)
                        , 0, 0,
                        outImage.Img.Width,
                        outImage.Img.Height, GraphicsUnit.Pixel);

                    }
                 }
                
                if(s==1)
                 imageviewerright.LoadImages(getBytes(firstBitmap));
                s++;
                firstBitmap.Save(@"c:\\temp\result\" + i + "-" + outPage.Images.Count + ".jpeg");

            }

            i++;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        List<byte[]> getBytes(Bitmap sourceBitmap)
        {
            MemoryStream ms = new MemoryStream();
            sourceBitmap.Save(ms, ImageFormat.Jpeg);

            return new List<byte[]>() { ms.ToArray() };

        }


        private int i;

        private void button1click(object sender, RoutedEventArgs e)
        {
            //for (i = 403555700; i < 403555800; i++)
            //{
            //    IList<InPage> input = GetData(i);
            //    StartEngine(input);
            //}

            IList<InPage> input = GetData(403555704);

            StartEngine(input);
        }


        private IList<InPage> GetData(long id)
        {

            IList<InPage> input = new List<InPage>();

            using (ProxyArsiv proxy = new ProxyArsiv())
            {
                var news = proxy.Get<News>(id, "2014");

                int clipNumber = 0;
                FilterExpression expression = new FilterExpression();

                expression.Criterias.Add(new Criteria() { CriteriaType = CriteriaTypes.Eq, FieldName = Newsclip2Fields.NewsId, FieldValue = news.Id.ToString() });

                var newsclips = proxy.GetList<Newsclip2>(expression, "2014");
                foreach (var newsclip in newsclips)
                {

                    var imageData = proxy.GetClipData(newsclip.ClipId, 2014);
                    var regionData = Encoding.UTF8.GetString(proxy.GetClipOcrZonesData(newsclip.ClipId, 2014));
                    var ocrchardata = Encoding.UTF8.GetString(proxy.GetClipOcrCharData(newsclip.ClipId, 2014).Data);

                    InPage page = GetInputPage(imageData, regionData, ocrchardata);

                    page.Number = clipNumber;
                    clipNumber++;

                    input.Add(page);

                    PaintZones(page, id);
                    PaintChars(page, id);
                    SeperateZones(page);

                }
            }
            
            return input;
        }


        private InPage GetInputPage(byte[] imageData, string regionData, string ocrchardata)
        {
            InPage page = new InPage(imageData);


            #region regiondataparsing
            string[] splitter1 = { "\r\n" };
            string[] splitter2 = { "#" };
            string[] splitter3 = { ";" };
            var splittedRegion = regionData.Split(splitter1, StringSplitOptions.RemoveEmptyEntries);
            foreach (var splitted in splittedRegion)
            {

                var splittedTemp = splitted.Split(splitter2, StringSplitOptions.RemoveEmptyEntries);
                string number = splittedTemp[0];
                string type = splittedTemp[1];
                Zone zone = new Zone();
                zone.Type = ParseZoneType(type);
                zone.Number = Int32.Parse(number);
                GraphicsPath path = new GraphicsPath();
                string[] splittedRects = splittedTemp[2].Split(splitter3, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < splittedRects.Length; i += 4)
                    {
                        string x = splittedRects[i].Replace(",", ".");
                        string y = splittedRects[i + 1].Replace(",", ".");
                        string w = splittedRects[i + 2].Replace(",", ".");
                        string h = splittedRects[i + 3].Replace(",", ".");

                        path.AddRectangle(new RectangleF(float.Parse(x, CultureInfo.InvariantCulture), float.Parse(y, CultureInfo.InvariantCulture), float.Parse(w, CultureInfo.InvariantCulture), float.Parse(h, CultureInfo.InvariantCulture)));

                    }
                Region reg = new Region(path);

                Matrix transformMatrix = new Matrix();
                transformMatrix.Scale(page.Img.HorizontalResolution / 200, page.Img.VerticalResolution / 200);
                reg.Transform(transformMatrix);

                path.Dispose();
                zone.Reg = reg;

                page.Zones.Add(zone);
            }
            #endregion

            #region ocrdataparsing


            float scale = page.Img.HorizontalResolution / 200f;
            string[] splitera1 = { "\r\n" };
            string[] splittera2 = { ";" };
            string[] splittedocrchar = ocrchardata.Split(splitera1, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i < splittedocrchar.Length; ++i)
            {
                var temp = splittedocrchar[i].Split(splittera2, StringSplitOptions.RemoveEmptyEntries);
                int zonenumber = int.Parse(temp[0]);

                string indexnumber = temp[2];
                for (int ia = 5; ia < temp.Length; ia += 4)
                {
                    float left = float.Parse(temp[ia].Replace(",", "."), CultureInfo.InvariantCulture);
                    float right = float.Parse(temp[ia + 1].Replace(",", "."), CultureInfo.InvariantCulture);
                    float bottom = float.Parse(temp[ia + 2].Replace(",", "."), CultureInfo.InvariantCulture);
                    float top = float.Parse(temp[ia + 3].Replace(",", "."), CultureInfo.InvariantCulture);


                    //float zoneLeft = (float.Parse(temp[ia].Replace(",", "."), CultureInfo.InvariantCulture))-page.Zones[zonenumber].Reg.GetBounds(grp).Left;
                    //float zoneRight = (float.Parse(temp[ia + 1].Replace(",", "."), CultureInfo.InvariantCulture)) - page.Zones[zonenumber].Reg.GetBounds(grp).X;
                    //float zoneBottom = (float.Parse(temp[ia + 2].Replace(",", "."), CultureInfo.InvariantCulture))- page.Zones[zonenumber].Reg.GetBounds(grp).Bottom;
                    //float zoneTop = (float.Parse(temp[ia + 3].Replace(",", "."), CultureInfo.InvariantCulture))-page.Zones[zonenumber].Reg.GetBounds(grp).Y;


                    RectangleF rect = new RectangleF(left * scale, top * scale, (right - left) * scale, (bottom - top) * scale);

                    // RectangleF zoneRect=new RectangleF((left * scale)-zoneX , (top * scale)-zoneY, ((right - left) * scale), ((bottom - top) * scale));

                    Character character = new Character();
                    character.Rect = rect;

                    character.Index = int.Parse(indexnumber);

                    page.Zones.Where(p => p.Number == zonenumber).First().Chars.Add(character);

                }
            }
            #endregion



            
            return page;

        }



        private void SeperateZones(InPage page)
        {


            MyImaging imaging = new MyImaging();

            foreach (var item in page.Zones)
            {
                Bitmap bmp = imaging.Crop(page.Img, item.Reg);
                if (item.Type == ZoneType.Header || item.Type == ZoneType.Text || item.Type == ZoneType.Title || item.Type == ZoneType.Spot || item.Type == ZoneType.Footer)
                {
                    Bitmap blackandwhite = imaging.GetBlackWhite(bmp);
                    //blackandwhite.Save("c:\\temp\\"+item.Number+".jpg");
                    //blackandwhite.Save("c:\\temp\\"+item.Type+" - "+ item.Number + ".bmp");
                }
                else if (item.Type == ZoneType.Image)
                {
                    Bitmap resized = imaging.ResizeFast(bmp, bmp.Width, bmp.Height);
                    //resized.Save("c:\\temp\\" +item.Type+" - "+ item.Number + ".jpg");

                }
                //else 
                //bmp.Save("c:\\temp\\"+item.Type+" - " +item.Number+".jpg");

            }
           
        }


        private void PaintChars(InPage page, long id)
        {
            float[] charHeight = new float[500];

            int index = 0;
            Bitmap cloned = Interpress.Library.Libraries.DbtLibrary.Image.Image.Clone(page.Img);
            using (Graphics g = Graphics.FromImage(cloned))
                foreach (var item in page.Zones)
                {
                    foreach (var itemChar in item.Chars)
                    {
                        Pen pen = new System.Drawing.Pen(staticsolidBrushes[index++ % staticsolidBrushes.Length], 1);
                        g.DrawRectangle(pen, itemChar.Rect.X, itemChar.Rect.Y, itemChar.Rect.Width, itemChar.Rect.Height);


                    }
                }
            string fileName = "c:\\temp\\" + id + "_char.jpg";
            cloned.Save(fileName);
            //imageviewerright.LoadImages(new List<byte[]>() { File.ReadAllBytes(fileName) });
            cloned.Dispose();
            
        }


        private void PaintZones(InPage page, long index)
        {

            int x = 0;
            Bitmap cloned = Interpress.Library.Libraries.DbtLibrary.Image.Image.Clone(page.Img);

            using (Graphics g = Graphics.FromImage(cloned))
                foreach (var item in page.Zones)
                {

                    g.FillRegion(staticsolidBrushes[x % staticsolidBrushes.Length], item.Reg);
                    g.DrawString(item.Type.ToString(), new Font("Arial", 14), Brushes.Red, new PointF(item.Reg.GetBounds(g).X, item.Reg.GetBounds(g).Y));
                    x++;


                }
            string fileName = "c:\\temp\\" + index + "_zone.jpg";
            cloned.Save(fileName);
            imageviewerleft.LoadImages(new List<byte[]>() { File.ReadAllBytes(fileName) });
            cloned.Dispose();
            
        }


        private ZoneType ParseZoneType(string type)
        {
            if (type == "Text")
                return ZoneType.Text;
            if (type == "Header")
                return ZoneType.Header;
            if (type == "Title")
                return ZoneType.Title;
            if (type == "Table")
                return ZoneType.Table;
            if (type == "Image")
                return ZoneType.Image;
            if (type == "Spot")
                return ZoneType.Spot;
            if (type == "Footer")
                return ZoneType.Footer;

            throw new ApplicationException("Unknow zone type");


        }

        #region staticSolidBrushes

        private static Brush[] staticsolidBrushes =
        {
            new SolidBrush(Color.FromArgb(100, Color.Red)),
            new SolidBrush(Color.FromArgb(100, Color.Blue)), new SolidBrush(Color.FromArgb(100, Color.Brown)),
            new SolidBrush(Color.FromArgb(100, Color.Yellow)), new SolidBrush(Color.FromArgb(100, Color.Violet)),
            new SolidBrush(Color.FromArgb(100, Color.Pink)), new SolidBrush(Color.FromArgb(100, Color.Lime))
        };
        #endregion

        class Utils
        {
            static internal int ConvertMMtoPixel(float mm, float dpi)
            {
                return Convert.ToInt32((mm / 25.4F) * dpi);
            }
            static internal int ConvertMMtoPixel(int mm, float dpi)
            {
                return Convert.ToInt32((mm / 25.4F) * dpi);
            }


            static internal int ConvertPixeltoMM(int pixel, float dpi)
            {
                return Convert.ToInt32((pixel / dpi) * 25.4F);
            }

            static internal float ConvertPixeltoMMF(float pixel, float dpi)
            {
                return Convert.ToSingle((pixel / dpi) * 25.4F);
            }

            static internal int ConvertPixeltoMM(float pixel, float dpi)
            {
                return Convert.ToInt32((pixel / dpi) * 25.4F);
            }
        }
    }
}
