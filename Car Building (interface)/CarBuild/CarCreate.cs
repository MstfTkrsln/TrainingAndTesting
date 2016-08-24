using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mime;
using System.Text;

namespace CarBuild
{
    public class CarCreate
    {
        public static ICar Create(Cars choosecar)
        {
            if (choosecar == Cars.Bmw)
                return new BmwBuilding();
            if (choosecar== Cars.Mercedes)
                return new MercedesBuilding();
            return null; 
        }


    }
}
