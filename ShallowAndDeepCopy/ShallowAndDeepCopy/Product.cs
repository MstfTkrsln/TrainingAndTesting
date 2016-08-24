using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ShallowAndDeepCopy
{
    /// <summary>
    /// Shallow and Deep Copy
    /// </summary>



    //Serializable Example
    public static class Extension
    {
        public static Product deepCopySerializable(this Product p)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, p);
                stream.Position = 0;
                return (Product)formatter.Deserialize(stream);
            }

        }
    }

    [Serializable]
    public class Product
    {
        
        public string name { get; set; }
        public long id { get; set; }
        public productDate dates { get; set; }

        public static Product ShallowCopy(Product p)
        {
            return (Product) p.MemberwiseClone();
        }
        

        public static Product DeepCopy(Product p)
        {
            Product newp=(Product) p.MemberwiseClone();
            newp.dates=new productDate(p.dates.productionDate, p.dates.ExpirationDate);
            return newp;
            
        }

       
    }
        
      [Serializable]
    public class productDate
    {
       
        public DateTime productionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public productDate(DateTime _pDatetime,DateTime _edDateTime )
        {
            productionDate = _pDatetime;
            ExpirationDate = _edDateTime;

        }

    }
}
