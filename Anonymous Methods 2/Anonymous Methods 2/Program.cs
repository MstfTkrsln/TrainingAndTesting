using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anonymous_Methods_2
{
    class Program
    {
        private delegate int Islem(int valprm, ref int refprm, out int outprm);

        static Islem yazdir()
        {
            return delegate(int valprm, ref int refprm, out int outprm)
            {Console.WriteLine("Valprm değeri : " + valprm);
                refprm++;
                outprm = 15;
                return valprm;
            };
        }

        static void Main(string[] args)
        {
            Islem _islem = yazdir();

            int refvar = 7;
            int outvar;
            int x = _islem(10, ref refvar, out outvar);

            Console.WriteLine("x :{0} , refvar :{1} , outvar :{2}",x,refvar,outvar);
            Console.ReadLine();
            

        }
    }
}
