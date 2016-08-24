using System.Collections.Generic;
using System.Drawing;
using Interpress.Library.Libraries.DbtLibrary.Imaging;
using Interpress.Library.ReconstructorEngine.InElements;
using Interpress.Library.ReconstructorEngine.OutElements;

namespace Interpress.Library.ReconstructorEngine.Templates
{
    class HeaderTextsImages : BaseTemplate
    {
        public override bool CanProcess(IList<InElements.InPage> pages)
        {
            zoneTypeCount = GetZoneTypeCount(pages);

            //Text-Image olmalı. Title ve Header Opsiyonel
            if (zoneTypeCount.ContainsKey(ZoneType.Text)/* && zoneTypeCount.ContainsKey(ZoneType.Header)*/ && zoneTypeCount.ContainsKey(ZoneType.Image) && /*!zoneTypeCount.ContainsKey(ZoneType.Title) &&*/ 
                !zoneTypeCount.ContainsKey(ZoneType.Footer) && !zoneTypeCount.ContainsKey(ZoneType.Spot) && !zoneTypeCount.ContainsKey(ZoneType.Table))
            {
               return true;
            }
            return false;
        }



        public override IList<OutElements.OutPage> Process(IList<InElements.InPage> pages)
        {
            
            MyImaging myImg = new MyImaging();

            IList<OutPage> outPages = new List<OutPage>();
           
            OutPage outPage = new OutPage(); //İlk Syafa

            float endHeightPoint = 5;
            float endWidthPoint;
            float headerBottomPoint = 5;
            int pageColumn;
            float lastZoneXPoint;
            float scale;
            int pageHeight =Utils.ConvertMMtoPixel(268, 72), pageWidth=Utils.ConvertMMtoPixel(190, 72);

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


                        outImage.Reg = outImage.Reg = new Region(new RectangleF(zone.Reg.GetBounds(grp).X * scale, zone.Reg.GetBounds(grp).Y * scale, zone.Reg.GetBounds(grp).Width * scale, zone.Reg.GetBounds(grp).Height * scale));

                        while (outImage.Img.Width > pageWidth)
                        {

                            outImage.Img = myImg.ResizeFast(outImage.Img, (int)(outImage.Img.Width * (0.90)), (int)(outImage.Img.Height * (0.90)));

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

                #region Title Yerleşirme (Opsiyonel Eğer varsa)

                foreach (Zone zone in page.Zones)
                {
                    //Sayfanın üst kısmına Header Yerleştirme.
                    if (zone.Type == ZoneType.Title)
                    {

                        OutImage outImage = new OutImage();

                        outImage.Img = GetCroppedAndBlackWhite(page.Img, zone);

                        scale = 72 / outImage.Img.HorizontalResolution;

                        outImage.Img = Decrease72Dpi(outImage.Img, scale);

                        Graphics grp = Graphics.FromImage(outImage.Img);


                        outImage.Reg = outImage.Reg = new Region(new RectangleF(zone.Reg.GetBounds(grp).X * scale, zone.Reg.GetBounds(grp).Y * scale, zone.Reg.GetBounds(grp).Width * scale, zone.Reg.GetBounds(grp).Height * scale));

                        while (outImage.Img.Width > pageWidth)
                        {

                            outImage.Img = myImg.ResizeFast(outImage.Img, (int)(outImage.Img.Width * (0.90)), (int)(outImage.Img.Height * (0.90)));

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

                SortedDictionary<int, Zone> sortedTextZones = SelectAndSortTextZones(page.Zones); //Text Zone'ların Sıralanması işlemi.

                //Text Zoneları yerleştirme.
                foreach (Zone zone in sortedTextZones.Values)
                {

                    OutImage outImage = new OutImage();

                    outImage.Img = GetCroppedAndBlackWhite(page.Img, zone);

                    scale = 72 / outImage.Img.HorizontalResolution;

                    outImage.Img = Decrease72Dpi(outImage.Img, scale);

                    CalculateCharRect(zone, outImage.Img, scale);

                    Graphics grp = Graphics.FromImage(outImage.Img);


                    outImage.Reg = new Region(new RectangleF(zone.Reg.GetBounds(grp).X * scale, zone.Reg.GetBounds(grp).Y * scale, zone.Reg.GetBounds(grp).Width * scale, zone.Reg.GetBounds(grp).Height * scale));



                    //TextZone'un Sayafayanın kalan alanına sığıp sığamadığının kontrolü yapılır.
                    if (outImage.Reg.GetBounds(grp).Height > (pageHeight - endHeightPoint))
                    {

                        //Sığmıyorsa sayfadaki yeni bir Text kolonuna sığıp sığamadığının kontrolü. Orayada sığmıyorsa Parçalama işlemi yapılır. Sığıyorsa yeni kolona yerleştrilir.
                        if (pageColumn == 1 && outImage.Reg.GetBounds(grp).Height > (pageHeight - endHeightPoint) &&
                            outImage.Reg.GetBounds(grp).Height/2 < (pageHeight - endHeightPoint))
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
                                outPage.Images.Add(separatedImages[i]);

                            }
                        }
                        else
                        {
                            if (outImage.Img.Width < pageWidth - lastZoneXPoint &&outImage.Img.Height < pageHeight - headerBottomPoint)//yeni kolona sığıyor mu kontrolü yapılır sığmıyorsa yeni page oluşturulur.
                            {
                                endWidthPoint = lastZoneXPoint + 10;

                                outImage.LocationPixel = new PointF(endWidthPoint, headerBottomPoint);

                                endHeightPoint = outImage.Img.Height+headerBottomPoint;

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

                                if (outImage.Img.Height < pageHeight - headerBottomPoint) //yeni sayfaya sığıyorsa yerleştir.
                                {

                                    outImage.LocationPixel = new PointF(endWidthPoint, endHeightPoint);

                                    endHeightPoint += outImage.Img.Height;
                                    lastZoneXPoint = endWidthPoint + outImage.Img.Width;

                                    newOutPage.Images.Add(outImage);

                                    pageHeight = Utils.ConvertMMtoPixel(282, 72);
                                    //yeni sayfa için yükseklik değerini günceleldik.


                                    outPage = newOutPage;
                                }
                                else                                            //yeni sayfaya sığmıyorsa parçalayıp yerleştir.
                                {

                                    OutImage[] separatedImages = SeparateTextZone(outImage, zone);

                                    for (int i = 0; i < separatedImages.Length; i++)
                                    {
                                        separatedImages[i].LocationPixel = new PointF(endWidthPoint, endHeightPoint);

                                        lastZoneXPoint += endWidthPoint;



                                        if (i != separatedImages.Length - 1)//son parça text zone olup olmadığına göre 2. kolon için değerleri ayarlama
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

                                    outImage.LocationPixel = new PointF(endWidthPoint, endHeightPoint);

                                    endHeightPoint += outImage.Img.Height;

                                    if (lastZoneXPoint < endWidthPoint + outImage.Img.Width)   //Text zone'larından en geniş olanının değerini sakla (başka bir zone yazının üstüne gelmemesi için)
                                        lastZoneXPoint = endWidthPoint + outImage.Img.Width;
                            
                                    outPage.Images.Add(outImage);

                                }
                    }

                    grp.Dispose();
                    
                }

                #endregion

                #region Image Yerleştirme

                endHeightPoint += 5;

                foreach (Zone zone in page.Zones)
                {
                    //Sayfanın alt kısmına Image Yerleştirme.
                    if (zone.Type == ZoneType.Image)
                    {

                        OutImage outImage = new OutImage();

                        outImage.Img = GetCroppedAndBlackWhite(page.Img, zone);

                        scale = 72 / outImage.Img.HorizontalResolution;

                        outImage.Img = Decrease72Dpi(outImage.Img, scale);

                        Graphics grp = Graphics.FromImage(outImage.Img);

                        outImage.Reg = outImage.Reg = new Region(new RectangleF(zone.Reg.GetBounds(grp).X * scale, zone.Reg.GetBounds(grp).Y * scale, zone.Reg.GetBounds(grp).Width * scale, zone.Reg.GetBounds(grp).Height * scale));

                        int maxResizeCount = 1;

                        Bitmap tempImage = Interpress.Library.Libraries.DbtLibrary.Image.Image.Clone(outImage.Img);


                        while (tempImage.Width > pageWidth - lastZoneXPoint && maxResizeCount < 6)//sağa yerleştirebilmek için %20 küçülterek ilerle
                        {

                            tempImage = myImg.ResizeFast(tempImage, (int) (tempImage.Width*(0.80)),(int) (tempImage.Height*(0.80)));

                            maxResizeCount++;

                            if (maxResizeCount == 6)
                            {
                                tempImage =(Bitmap) outImage.Img.Clone();

                                while (tempImage.Height > pageHeight - endHeightPoint &&maxResizeCount < 11) //aşağı yerleştirebilmek için %20 küçülterek ilerle
                                {

                                    tempImage = myImg.ResizeFast(tempImage, (int) (tempImage.Width*(0.80)),
                                        (int) (tempImage.Height*(0.80)));
                                    maxResizeCount++;


                                }

                            }
                        }
                        if (0 < maxResizeCount && maxResizeCount < 6)//sağa yerleştirmeye  
                            {

                                 if (pageColumn==1)//tek kolan var ise yeni kolona yerleştir sığmıyorsa yeni sayfa yarat
                                 {
                                     
                                        
                                            if (tempImage.Height < pageHeight - headerBottomPoint)
                                            {
                                                outImage.Img=(Bitmap)tempImage.Clone();
                                                outImage.LocationPixel = new PointF(lastZoneXPoint,headerBottomPoint );
                                                //yeni
                                                endWidthPoint = lastZoneXPoint;
                                                lastZoneXPoint += outImage.Img.Width;

                                                if (endHeightPoint < headerBottomPoint + outImage.Img.Height)  //sayfa yatayındaki en uzun heigth point noktasını tut.Zone'lar üstüste gelmemesi için.
                                                        endHeightPoint = headerBottomPoint + outImage.Img.Height;
                                                    
                                                
                                                 pageColumn++;
                                            }
                                        
                                            else
                                                maxResizeCount = 11;
                                    
                                }
                                    
                                else if (tempImage.Height < pageHeight - endHeightPoint) //birden fazla kolon var ise son zone'un altına sığıyorsa yerleştir.sığmıyorsa yeni sayfa yarat.
                                {
                                        outImage.Img = (Bitmap)tempImage.Clone();
                                        outImage.LocationPixel = new PointF(endWidthPoint, endHeightPoint);
                                        //yeni
                                        endHeightPoint += outImage.Img.Height+5;
                                        lastZoneXPoint += outImage.Img.Width;
                                        
                                }
                                else
                                {
                                        maxResizeCount = 11;
                                }


                            }


                       else if (5 < maxResizeCount && maxResizeCount < 11) //alta yerleştir  
                       {

                                    if (tempImage.Width < pageWidth - endWidthPoint)
                                        //genişliği sığıyosarsa yerleştir sığmıyor ise yeni sayfa yarat.
                                    {
                                        outImage.Img = outImage.Img = (Bitmap) tempImage.Clone();
                                        outImage.LocationPixel = new PointF(endWidthPoint, endHeightPoint);
                                        //yeni
                                        endHeightPoint += outImage.Img.Height+5;
                                        lastZoneXPoint=endWidthPoint+ outImage.Img.Width;

                                    }
                                    else
                                    {
                                        maxResizeCount = 11;
                                    }


                        }


                        if (maxResizeCount == 11)   // Syafaya Sığmadı. Yeni page yaratıp ona yerleştir. 
                        {

                                    outPages.Add(outPage); //sayfayı kaydet yeni bir sayfas oluştur



                                    OutPage newOutPage = new OutPage();


                                    while (tempImage.Width > pageWidth)
                                    {

                                        tempImage = myImg.ResizeFast(tempImage, (int)(tempImage.Width * (0.80)), (int)(tempImage.Height * (0.80)));

                                    }

                                    endWidthPoint = 5;
                                    endHeightPoint = 5;
                                    pageColumn = 1;
                                    headerBottomPoint = 5;

                                    outImage.Img =(Bitmap) tempImage.Clone();

                                    outImage.Reg = new Region(new RectangleF(endWidthPoint, endHeightPoint, tempImage.Width, tempImage.Height));

                                    outImage.LocationPixel = new PointF(endWidthPoint, endHeightPoint);

                                    lastZoneXPoint = outImage.Img.Width+endWidthPoint;
                                    endHeightPoint += outImage.Img.Height+5;

                                    pageHeight = Utils.ConvertMMtoPixel(282, 72); //yeni sayfa için yükseklik değerini günceleldik.

                                    newOutPage.Images.Add(outImage);
                            
                                    outPage = newOutPage;


                        }
                        else  //ilk sayfaya sığdı region değerlerini düzeltiyoruz ve ilk sayfaya ekliyoruz.
                        {
                                    outImage.Reg = new Region(new RectangleF(outImage.LocationPixel.X, outImage.LocationPixel.Y, tempImage.Width, tempImage.Height));
                            

                                    outPage.Images.Add(outImage);
                        }
                        
                        tempImage.Dispose();
                        grp.Dispose();
                    }


                }


                #endregion
                
            }


            outPages.Add(outPage); //son sayfada eklenir.

           
            return outPages;
            
        }


        
    }
}

