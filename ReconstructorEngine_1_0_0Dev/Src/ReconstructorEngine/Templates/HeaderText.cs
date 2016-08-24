using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Interpress.Library.Libraries.DbtLibrary.Imaging;
using Interpress.Library.ReconstructorEngine.InElements;
using Interpress.Library.ReconstructorEngine.OutElements;


namespace Interpress.Library.ReconstructorEngine.Templates
{
    class HeaderText : BaseTemplate
    {
        Dictionary<ZoneType, int> zoneTypeCount;
        public override bool CanProcess(IList<InElements.InPage> pages)
        {
            zoneTypeCount = GetZoneTypeCount(pages);

            if (zoneTypeCount.ContainsKey(ZoneType.Text)/* && zoneTypeCount.ContainsKey(ZoneType.Header)*/ && !zoneTypeCount.ContainsKey(ZoneType.Image) && !zoneTypeCount.ContainsKey(ZoneType.Title) && !zoneTypeCount.ContainsKey(ZoneType.Footer) && !zoneTypeCount.ContainsKey(ZoneType.Spot) && !zoneTypeCount.ContainsKey(ZoneType.Table))
            {
                return true;
            }
            return false;
        }

        public override IList<OutElements.OutPage> Process(IList<InElements.InPage> pages)
        {
            MyImaging myImg = new MyImaging();

            IList<OutPage> outPages = new List<OutPage>();

            OutPage outPage = new OutPage(); //Ana sayfa

            float endHeightPoint = 5;
            float endWidthPoint;
            float headerBottomPoint = 5;
            int pageColumn;
            float lastZoneXPoint;
            float imageBottomPoint;
            float scale;
            int pageHeight = Utils.ConvertMMtoPixel(268, 72), pageWidth = Utils.ConvertMMtoPixel(190, 72);



            foreach (InPage page in pages)
            {

                pageColumn = 1;
                lastZoneXPoint = 0;
                endWidthPoint = 5;
                #region Header Yerleştirme

                foreach (Zone zone in page.Zones)
                {
                    //Sayfanın üst kısmına Header Yerleştirme.
                    if (zone.Type == ZoneType.Header)
                    {

                        OutImage outImage = new OutImage();

                        outImage.Img = GetCroppedAndBlackWhite(page.Img, zone);

                        scale = 72 / outImage.Img.HorizontalResolution;

                        outImage.Img = Decrease72Dpi(outImage.Img, scale);

                        Graphics grp = Graphics.FromImage(outImage.Img);


                        outImage.Reg =
                            outImage.Reg =
                                new Region(new RectangleF(zone.Reg.GetBounds(grp).X * scale,
                                    zone.Reg.GetBounds(grp).Y * scale, zone.Reg.GetBounds(grp).Width * scale,
                                    zone.Reg.GetBounds(grp).Height * scale));

                        while (outImage.Img.Width > pageWidth)
                        {

                            outImage.Img = myImg.ResizeFast(outImage.Img, (int)(outImage.Img.Width * (0.90)),
                                (int)(outImage.Img.Height * (0.90)));

                        }

                        int leftSpace = (pageWidth - outImage.Img.Width) / 2;

                        outImage.LocationPixel = new PointF(leftSpace, endHeightPoint);

                        endHeightPoint += outImage.Img.Height + 5;

                        headerBottomPoint = endHeightPoint;

                        endWidthPoint = 5;

                        outPage.Images.Add(outImage);

                        grp.Dispose();

                    }
                }

                #endregion

                #region Text Zone'ları Yerleştirme

                SortedDictionary<int, Zone> sortedTextZones = SelectAndSortTextZones(page.Zones);
                //Text Zone'ların Sıralanması işlemi.

                //Text Zoneları yerleştirme.
                foreach (Zone zone in sortedTextZones.Values)
                {

                    OutImage outImage = new OutImage();

                    outImage.Img = GetCroppedAndBlackWhite(page.Img, zone);

                    scale = 72 / outImage.Img.HorizontalResolution;

                    outImage.Img = Decrease72Dpi(outImage.Img, scale);

                    CalculateCharRect(zone, outImage.Img, scale);

                    Graphics grp = Graphics.FromImage(outImage.Img);


                    outImage.Reg =
                        new Region(new RectangleF(zone.Reg.GetBounds(grp).X * scale, zone.Reg.GetBounds(grp).Y * scale,
                            zone.Reg.GetBounds(grp).Width * scale, zone.Reg.GetBounds(grp).Height * scale));



                    //TextZone'un Sayafayanın kalan alanına sığıp sığamadığının kontrolü yapılır.
                    if (outImage.Reg.GetBounds(grp).Height > (pageHeight - endHeightPoint))
                    {

                        //Sığmıyorsa sayfadaki yeni bir Text kolonuna sığıp sığamadığının kontrolü. Orayada sığmıyorsa Parçalama işlemi yapılır. Sığıyorsa yeni kolona yerleştrilir.
                        if (pageColumn == 1 && outImage.Reg.GetBounds(grp).Height > (pageHeight - endHeightPoint) &&
                            outImage.Reg.GetBounds(grp).Height / 2 < (pageHeight - endHeightPoint))
                        {

                            OutImage[] separatedImages = SeparateTextZone(outImage, zone);

                            for (int i = 0; i < separatedImages.Length; i++)
                            {
                                separatedImages[i].LocationPixel = new PointF(endWidthPoint, endHeightPoint);

                                lastZoneXPoint += endWidthPoint;



                                if (i != separatedImages.Length - 1)
                                //son parça text zone olup olmadığına göre 2. kolon için değerleri ayarlama
                                {
                                    endWidthPoint += separatedImages[i].Img.Width + 10;
                                    endHeightPoint = headerBottomPoint;//HATAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa- Yukarıdaki text in width i yerine kesilmiş olan textin with ini alıyor

                                }
                                else
                                {
                                    endHeightPoint += separatedImages[i].Img.Height;

                                }
                                pageColumn = i + 1;
                                outPage.Images.Add(separatedImages[i]);

                            }
                        }
                        else
                        {
                            if (outImage.Img.Width < pageWidth - lastZoneXPoint &&
                                outImage.Img.Height < pageHeight - headerBottomPoint)
                            //yeni kolona sığıyor mu kontrolü yapılır sığmıyorsa yeni page oluşturulur.
                            {
                                endWidthPoint = lastZoneXPoint + 10;

                                outImage.LocationPixel = new PointF(endWidthPoint, headerBottomPoint);

                                endHeightPoint = outImage.Img.Height + headerBottomPoint;

                                lastZoneXPoint = endWidthPoint + outImage.Img.Width;

                                pageColumn++;


                                outPage.Images.Add(outImage);
                            }
                            else
                            {
                                outPages.Add(outPage); //ilk sayfayı listeye ekle yeni bir sayfa aç
                                OutPage newOutPage = new OutPage();
                                endWidthPoint = 5;
                                endHeightPoint = 5;
                                pageColumn = 1;
                                headerBottomPoint = 5;

                                if (outImage.Img.Height < pageHeight - headerBottomPoint)
                                //yeni sayfaya sığıyorsa yerleştir.
                                {

                                    outImage.LocationPixel = new PointF(endWidthPoint, endHeightPoint);

                                    endHeightPoint += outImage.Img.Height;
                                    lastZoneXPoint = endWidthPoint + outImage.Img.Width;

                                    newOutPage.Images.Add(outImage);

                                    pageHeight = Utils.ConvertMMtoPixel(282, 72);
                                    //yeni sayfa için yükseklik değerini günceleldik.


                                    outPage = newOutPage;
                                }
                                else //yeni sayfaya sığmıyorsa parçalayıp yerleştir.
                                {

                                    OutImage[] separatedImages = SeparateTextZone(outImage, zone);

                                    for (int i = 0; i < separatedImages.Length; i++)
                                    {
                                        separatedImages[i].LocationPixel = new PointF(endWidthPoint, endHeightPoint);

                                        lastZoneXPoint += endWidthPoint;



                                        if (i != separatedImages.Length - 1)
                                        //son parça text zone olup olmadığına göre 2. kolon için değerleri ayarlama
                                        {
                                            endWidthPoint += separatedImages[i].Img.Width + 10;
                                            endHeightPoint = headerBottomPoint;

                                        }
                                        else
                                        {
                                            endHeightPoint += separatedImages[i].Img.Height;

                                        }
                                        pageColumn = i + 1;

                                        outPage = newOutPage;

                                        outPage.Images.Add(separatedImages[i]);
                                    }



                                }

                            }
                        }

                    }
                    else
                    {
                        if (pageColumn != 1)
                        {
                            outImage.LocationPixel = new PointF(endWidthPoint, endHeightPoint);

                            endHeightPoint += outImage.Img.Height;

                            lastZoneXPoint = endWidthPoint + outImage.Img.Width;

                            outPage.Images.Add(outImage);
                        }
                        else
                        {
                            float leftspace = 0;
                            if (sortedTextZones.Count==1)
                            {
                                leftspace = (pageWidth-outImage.Img.Width-5)/2;

                            }
                            outImage.LocationPixel = new PointF(endWidthPoint+leftspace, endHeightPoint);

                            endHeightPoint += outImage.Img.Height;

                            
                            if (lastZoneXPoint < endWidthPoint + outImage.Img.Width)//Text zone'larından en geniş olanının değerini sakla (image yazının üstüne gelmemesi için)
                                lastZoneXPoint = endWidthPoint + outImage.Img.Width;

                            outPage.Images.Add(outImage);


                        }
                    }

                    grp.Dispose();

                }

                #endregion
            }


            outPages.Add(outPage);


            return outPages;
        }
    }
}
