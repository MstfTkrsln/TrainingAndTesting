using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List_in_Class
{
    public class CarManager
    {
        public static List<Car> ListCars = new List<Car>();

      

        Car[] Bmw = {new Car("Bmw", "3.16i", "2005", "Beyaz","Kiralık"), new Car("Bmw", "5.20i", "2011", "Siyah","Satılık")};

        Car[] Mercedes = {new Car("Mercedes", "CLK200", "2001", "Mavi","Kiralık"), new Car("Mercedes", "C180", "2004", "Gri","Kiralık")};

        Car[] Fiat = { new Car("Fiat", "Doblo", "2009", "Beyaz","Satılık")};

        //public CarManager()
        //{
        //    ListCars.AddRange(Bmw);
        //    ListCars.AddRange(Mercedes);
        //    yazdir();
        //}

        public CarManager()
        {
            foreach (var item in ListCars)
            {
                //if (item.durum == "Satılık")
                //{


                    Console.WriteLine(
                        " Araç Marka :\t{0}\n Araç Model :\t{1}\n Model Yılı :\t{2}\n Araç Renk  :\t{3}\n Araç Durum:\t{4}\n" , item.Marka,
                        item.Model, item.ModelYil, item.Renk,item.durum);
                    Console.WriteLine("*************************");
                //}
            }
      
        }

    }
}
