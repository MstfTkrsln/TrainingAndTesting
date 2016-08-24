using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Mylist
{
    class FastList:IEnumerable
    {
        public int[] Dizi = new int[5];
        int i=-1;
        
        //public bool MoveNext()
        //    {
        //        if (i == Dizi.Length - 1)
        //            {
        //                Reset();
        //                return false;
        //            }

        //        else
        //            {
        //                i++;
                        
        //            return true;
        //            }
        //        }

        //    public void Reset()
        //    {
        //        i = -1;
        //    }

        //    public object Current
        //    {
                
        //        get { return Dizi[i]; }
        //    }
            
        
            public IEnumerator  GetEnumerator()
            {
                for (int i = 0; i < Dizi.Length; i++)
                 yield  return Dizi[i];
            }
     
    }
}
