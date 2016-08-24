using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ExceptionCreating
{
    class ClassArray
    {
        public ClassArray(Array dizi)
        {
            if(dizi==null)
            {
                throw new DiziNullException("Dizi Null Değeri Taşıyor...!");
            }
            if (dizi.Length>100)
            {
                throw new DiziTasmaException("Dizi Sınırlarını Aştınız...!");
            }
        }

        [Serializable]
        public class DiziNullException: Exception
        {
            public DiziNullException()
            {
            }

            public DiziNullException(string message): base(message)
            {
            }

            
        }

        public class DiziTasmaException : Exception
        {

            public DiziTasmaException()
            {
            }

            public DiziTasmaException(string message) : base(message)
            {
            }

            public DiziTasmaException(string message, Exception inner) : base(message,inner)
            {
            }

           
            
        }
    }
}
