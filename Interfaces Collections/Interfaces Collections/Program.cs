using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Interfaces_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region mylist
            //MyList ml=new MyList();

            //ml.Add("mustafa");
            //ml.Add(122312);
            //ml.Add("Yazılım");
            //ml.Insert(1,"tekeraslan");
            //foreach (var item in ml)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region comparable
           // Teams.Bjk b = new Teams.Bjk() { Guc = 98 };
           // Teams.Fener f = new Teams.Fener() { Guc = 96 };

           // int x=b.CompareTo(f);
           // Console.WriteLine(x);
            
           //Teams t=new Teams();
           // Console.WriteLine(t.Compare(f, b));
            #endregion

            #region clone


            Team bjk=new Team();

            Team fb = (Team )bjk.Clone();
            fb.TeamName = "Fenerbahçe";
            fb.Guc = 30;
            Team fbCopy = bjk;
            
            bjk.Guc = 100;
            fbCopy.Guc = 50;
            
            Console.WriteLine(bjk);
            Console.WriteLine(fb);
            Console.WriteLine(fbCopy);//direk kopyalandığı için adresileri eşit oldu.



            #endregion 

            Console.ReadLine();
        }

        
    }
}
