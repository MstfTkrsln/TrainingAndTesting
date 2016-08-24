using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Commands;


namespace Commands
{
    public interface IGraphic
    {
        void Draw();
    }
}




namespace Commands
{
    public class Circle
        : IGraphic
    {
        #region IGraphic Members

        public void Draw()
        {
            Console.WriteLine("Circle...");
        }

        #endregion
    }
}





namespace Commands
{
    public class Rectangle
        : IGraphic
    {
        #region IGraphic Members

        public void Draw()
        {
            Console.WriteLine("Rectangle...");
        }

        #endregion
    }
}

//Console Application tipinden olan uygulamamız, Commands isimli sınıf kütüphanesini referans etmekte olup başlangıçta aşağıdaki kod içeriğine sahiptir.



namespace CSharp4Features
{
    class Program
    {



        static void Main(string[] args)
        {
            #region Başlangıçtaki durumumuz

            Draw<Circle>(new Circle());
            Draw<Rectangle>(new Rectangle());


            DrawAssmbly<Circle>(new Circle());
            DrawAssmbly<Rectangle>(new Rectangle());

            DrawDynamic(new Circle());
            DrawDynamic(new Rectangle());



            Console.ReadLine();

            #endregion
        }


        static void Draw<T>(T graphObject) where T : IGraphic
        {
            graphObject.Draw();
        }

        static void DrawAssmbly<T>(T graphObject)
        {
            MethodInfo methodInfo = typeof(T).GetMethod("Draw");

            if (methodInfo == null)
            {
                Console.WriteLine("Method bulunamadı");
            }

            methodInfo.Invoke(graphObject, new object[0]);
        }

        static void DrawDynamic(dynamic graphObject)
        {
            
            graphObject.Draw();
        }

    }
}