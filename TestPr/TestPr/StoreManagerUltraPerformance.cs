using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interpress.Library.LibPr;

namespace Interpress.WinClient.TestPr
{
    class StoreManagerUltraPerformance<T, H> : StoreManager<T, H> 
    {
        private int maxId = 100;
        private H[] elements;

        public StoreManagerUltraPerformance()
        {
            elements=new H[maxId];
        }

        public override void Add(T key, H item)
        {
            int valKey = Convert.ToInt32(key.ToString());
            if (maxId < valKey)
            {
                int newLenght = (int) (valKey*1.25);
                H[] dizi = new H[newLenght];
                for (int i = 0; i < maxId; ++i)
                    dizi[i] = elements[i];
                maxId = newLenght;
                dizi[valKey] = item;
                elements = dizi;
            }
            else elements[valKey] = item;
        }

        public override void Remove(T key)
        {
            int valKey = Convert.ToInt32(key.ToString());
            if (maxId > valKey)
                elements[valKey] = default(H);
        }

        public override H Get(T key)
        {
             int valKey = Convert.ToInt32(key.ToString());
            if (maxId > valKey)
                return elements[valKey];
            return default(H);
        }
    }
}
