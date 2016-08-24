using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;



namespace Reflection2
{

    [AttributeUsage(
        AttributeTargets.Field,
        AllowMultiple = false,
        Inherited = true)]
    public class ZorunluAlanAttribute : Attribute
    {
    }
    


    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Reflection
            Type studentType = typeof (Student);

            FieldInfo[] studentFieldInfos = studentType.GetFields(BindingFlags.Public | BindingFlags.Instance);

            foreach (FieldInfo info in studentFieldInfos)
            {
                Console.WriteLine("Alan  :" + info.Name + "   Field Type :" + info.FieldType);

            }
            #endregion

            #region Attribute

            Console.WriteLine("\nAttributes\n");
            StudentAttribute s1=new StudentAttribute();
            s1.Name = null;

            if (ZorunlulukKontrolu.Dogrula(s1))
                Console.WriteLine("Zorunlu alanlar Doldurulmuş");
            Console.WriteLine("Zorunlu Alanlar Doldurulmamış 'Exception'");

            #endregion


            Console.ReadLine();
        }


        public static class ZorunlulukKontrolu
        {
            public static bool Dogrula(object dogrulanacakOrnek)
            {
                Type dogrulamacakTur = dogrulanacakOrnek.GetType();

                FieldInfo[] dogrulanacakTurAlanlari =
                    dogrulamacakTur.GetFields(BindingFlags.Public | BindingFlags.Instance);


                foreach (FieldInfo dogrulanacakTurAlani in dogrulanacakTurAlanlari)
                {
                    object[] zorunluAlanOznitelikleri =
                        dogrulanacakTurAlani.GetCustomAttributes(typeof (ZorunluAlanAttribute), true);

                    if (zorunluAlanOznitelikleri.Length != 0)
                    {
                        string alanDegeri = dogrulanacakTurAlani.GetValue(dogrulanacakOrnek) as string;

                        if (string.IsNullOrEmpty(alanDegeri))
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }
    }
}
