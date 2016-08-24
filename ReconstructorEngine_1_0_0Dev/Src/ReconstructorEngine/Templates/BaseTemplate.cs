using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using Interpress.Library.Libraries.DbtLibrary.Imaging;
using Interpress.Library.ReconstructorEngine.InElements;
using Interpress.Library.ReconstructorEngine.OutElements;

namespace Interpress.Library.ReconstructorEngine.Templates
{
   abstract class BaseTemplate
    {

       public abstract bool CanProcess(IList<InPage> pages);
       public abstract IList<OutPage> Process(IList<InPage> pages);
       public Dictionary<ZoneType, int> zoneTypeCount;


       /// <summary>
       /// Eğer Zonetype text türünden ise Crop ve BlackandWhite işlemleri yapılır. Değilse Sadece crop işlemi yapılır.
       /// </summary>
       /// <param name="pageBitmap"></param>
       /// <param name="zone"></param>
       /// <returns></returns>
       protected Bitmap GetCroppedAndBlackWhite(Bitmap pageBitmap,Zone zone)
       {
           MyImaging myImg = new MyImaging();

           if (zone.Type != ZoneType.Image && zone.Type != ZoneType.Table && zone.Type != ZoneType.Spot)
           {
              return myImg.GetBlackWhite8Bit(myImg.Crop(pageBitmap, zone.Reg));
           }
           else
           {
              return myImg.Crop(pageBitmap, zone.Reg);
           }
       }

       /// <summary>
       /// Zone Tipleri ve Sayılarına göre Listeye aktarılır.
       /// </summary>
       /// <param name="pages"></param>
       /// <returns></returns>
       protected Dictionary<ZoneType, int> GetZoneTypeCount(IList<InPage> pages)
       {

           Dictionary<ZoneType,int> ZoneTypeCount=new Dictionary<ZoneType, int>();

           foreach (InPage page in pages)
           {
               foreach (Zone zone in page.Zones)
               {
                   if (ZoneTypeCount.ContainsKey(zone.Type))
                   {
                       ZoneTypeCount[zone.Type]++;
                   }
                   else
                   {
                       ZoneTypeCount.Add(zone.Type,1);
                   }

               }
           }

           return ZoneTypeCount;

       }

       /// <summary>
       /// Bitmap 72dpi olarak ayarlanır.
       /// </summary>
       /// <param name="bmp"></param>
       /// <returns></returns>
       protected Bitmap Decrease72Dpi(Bitmap bmp,float rate)
       {
           MyImaging myImg=new MyImaging();

           MemoryStream ms = new MemoryStream();
           
           bmp.Save(ms, ImageFormat.Jpeg);

           byte[] bmpArray = ms.GetBuffer();
               
           bmpArray = myImg.ChangeResolution(bmpArray, rate, 72);

           //bmpArray=myImg.ScaleTo(bmpArray, bmp.Width, bmp.Height);

           ms.SetLength(0);
           ms.Write(bmpArray, 0, bmpArray.Count());

           Bitmap bmp72dpi= (Bitmap)Image.FromStream(ms);

           

           ms.Dispose();

           return bmp72dpi;


       }

       /// <summary>
       /// Karakterlerin zone içerisindeki koordinat değerlerini belirler ve Character sınıfındaki ZoneRect değeri Doldurulur.
       /// </summary>
       /// <param name="zone"></param>
       /// <param name="outImage"></param>
       /// <param name="scale"></param>
       protected void CalculateCharRect(Zone zone,Bitmap outImage,float scale)
       {
           Graphics grp = Graphics.FromImage(outImage);

           foreach (Character ch in zone.Chars)
           {
               float charZoneX = ch.Rect.X - zone.Reg.GetBounds(grp).Left;
               float charZoneY = ch.Rect.Y - zone.Reg.GetBounds(grp).Top;
               float charZoneW = ch.Rect.Width;
               float charZoneH = ch.Rect.Height;

               ch.ZoneRect=new RectangleF(charZoneX*scale,charZoneY*scale,charZoneW*scale,charZoneH*scale);
               //grp.DrawRectangle(new Pen(Brushes.Red), new Rectangle((int)(ch.ZoneRect.X), (int)(ch.ZoneRect.Y), (int)(ch.ZoneRect.Width), (int)(ch.ZoneRect.Height)));
               
               
           }
           grp.Dispose();
           

       }

       /// <summary>
       /// Tipi Text olan zone'ları sıralar.
       /// </summary>
       /// <param name="zones"></param>
       /// <returns></returns>
       protected SortedDictionary<int, Zone> SelectAndSortTextZones(IList<Zone> zones)
       {
          SortedDictionary<int, Zone> sortedTextZones = new SortedDictionary<int, Zone>();

           foreach (Zone zone in zones)
           {
               if (zone.Type == ZoneType.Text)
               {
                   
                   sortedTextZones.Add(zone.Number, zone);
               }
           }

           return sortedTextZones;
       }


       /// <summary>
       /// Text Zone'u iki eşit parçaya böler
       /// </summary>
       /// <param name="outImage"></param>
       /// <param name="zone"></param>
       /// <returns></returns>
       protected OutImage[] SeparateTextZone(OutImage outImage,Zone zone)
       {
          MyImaging myImg=new MyImaging();

           Graphics grp = Graphics.FromImage(outImage.Img);

           OutImage[] separetedZones ={new OutImage(), new OutImage()};

           //ortadaki karakteri çizme
           //grp.DrawLine(new Pen(Brushes.Red), 0, zone.Chars[zone.Chars.Count / 2 ].ZoneRect.Top - 2, outImage.Img.Width, zone.Chars[zone.Chars.Count / 2].ZoneRect.Top - 2);

           //grp.DrawRectangle(new Pen(Brushes.Red), new Rectangle((int)zone.Chars[zone.Chars.Count / 2].ZoneRect.X, (int)zone.Chars[zone.Chars.Count / 2].ZoneRect.Y,(int) zone.Chars[zone.Chars.Count / 2].ZoneRect.Width,(int) zone.Chars[zone.Chars.Count / 2].ZoneRect.Height));


#region Text Zone'u ortadaki karalteri baz alarak ikiye bölme işlemi

           try
           {
           Region cropRegion = new Region(new RectangleF(0, 0, outImage.Img.Width, zone.Chars[zone.Chars.Count / 2].ZoneRect.Top -5));
           
           separetedZones[0].Img= myImg.Crop(outImage.Img, cropRegion);

           separetedZones[0].Reg = cropRegion;
           

           Region cropRegion2 = new Region(new RectangleF(0, cropRegion.GetBounds(grp).Height, outImage.Img.Width, outImage.Img.Height-cropRegion.GetBounds(grp).Height));

           separetedZones[1].Img = myImg.Crop(outImage.Img, cropRegion2);

           separetedZones[1].Reg = cropRegion2;

           }
           catch (Exception)
           {
               throw new Exception("Text Zone Parçalanamıyor.Karakter bilgisi doğru gelmemiş olabilir.");
           }

#endregion
           grp.Dispose();
           return separetedZones;
       }
    }
}
