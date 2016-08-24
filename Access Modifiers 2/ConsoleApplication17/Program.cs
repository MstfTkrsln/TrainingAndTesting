using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApplication17
{
    class Program
    {
        class first: second
        {
            public first()
            {
                 
                Console.WriteLine("first class");
            }
        }

        class second : third
        {
           
            protected second()
            {
                
                Console.WriteLine("Second class");
            }
        }

         class third

        {
            protected third()
            {
                 
                fourth f=new fourth();
                Console.WriteLine("Third Class");
                
            }

              public class fourth:fifth
                {
                   
                    internal fourth()
                    {
                        
                        Console.WriteLine("Fourth Class");
                    }
                }

               public class fifth
                {
                    protected fifth()
                    {
                        sixth sx=new sixth();
                        Console.WriteLine("Fifth Class");
                    }

                    public class sixth
                    {
                        public sixth ()
                        {
                            seventh sv=new seventh();
                            Console.WriteLine("Sixth Class");
                        }
                    }
                }
             }

        class seventh
        {
            
            public seventh()
            {
                
                Console.WriteLine("Seven Class");
            }
        }


        static void Main(string[] args)
        {
            //access modifiers
            first f=new first();
            Console.ReadKey();
        }
    }
}
