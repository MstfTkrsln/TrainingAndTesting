using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Interfaces_Collections
{
    class Teams:IComparer
    {
        public class Bjk:IComparable
        {
            public int Guc { get; set; }


            public int CompareTo(object obj)
            {
                Fener f = (Fener) obj; 
                
                if (f.Guc > this.Guc)
                    return -1;
                else if(f.Guc==this.Guc)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }

            }
            
        }

        public class Fener:IComparable
        {
            public int Guc { get; set; }

           

            public int CompareTo(object obj)
            {
            Bjk b = (Bjk) obj; 
                
                if (b.Guc > this.Guc)
                    return -1;
                else if(b.Guc==this.Guc)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }

            }
            }

        public int Compare(object x, object y)
        {
            Fener f = (Fener) x;
            Bjk b = (Bjk) y;
            if (b.Guc > f.Guc)
                return 1;
            else
            {
                return -1;
            }
        }
    }
      
    
}
