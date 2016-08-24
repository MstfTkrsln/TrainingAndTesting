using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            

            BuilderDirector director;
           
            director = new BuilderDirector((new HighSpeedNotebook()));
            NotebookProduct highSpeedNotebook = director.BuildNotebook();
            PrintProductDetail(highSpeedNotebook);

            director = new BuilderDirector((new StandartNotebook()));
            NotebookProduct standartSpeedNotebook = director.BuildNotebook();
            PrintProductDetail(standartSpeedNotebook);

            Console.ReadLine();

        }

        public static void PrintProductDetail(NotebookProduct product)
        {
            Console.WriteLine("GraphicCard: " + product.ProductDisplayEnvironment.GraphicCard);
            Console.WriteLine("ScreenWide: " + product.ProductDisplayEnvironment.ScreenWide);
            Console.WriteLine("ScreenResolution: " + product.ProductDisplayEnvironment.ScreenResolution);
            Console.WriteLine("Processor: " + product.ProductOEMEnvironment.Processor);
            Console.WriteLine();
        }
     }




    /// <summary>
    /// DisplayEnvironment Entity
    /// </summary>
    public class DisplayEnvironment
    {
        public string GraphicCard { get; set; }
        public string ScreenWide { get; set; }
        public string ScreenResolution { get; set; }
    }


    /// <summary>
    /// DisplayEnvironment Entity
    /// </summary>
    public class OEMEnvironment
    {
        public string Processor { get; set; }
    }

    /// <summary>
    /// Product Class
    /// </summary>
    public class NotebookProduct
    {
        public DisplayEnvironment ProductDisplayEnvironment { get; set; }
        public OEMEnvironment ProductOEMEnvironment { get; set; }
    }

    /// <summary>
    /// Notebook Arayüzü.Notebook için gerekli parçaların şablonudur.
    /// </summary>
    public interface INotebookBuilder
    {
        DisplayEnvironment BuildDisplayEnvironment();
        OEMEnvironment BuildOEMEnvironment();
    }

    /// <summary>
    /// ConcreteBuilder for StandartNotebook
    /// </summary>
    public class StandartNotebook : INotebookBuilder
    {
        public DisplayEnvironment BuildDisplayEnvironment()
        {
            return new DisplayEnvironment() { GraphicCard = "Standart Graphic Card", ScreenResolution = "648 x 760", ScreenWide = "12''" };
        }

        public OEMEnvironment BuildOEMEnvironment()
        {
            return new OEMEnvironment() { Processor = "Standart Processor" };
        }
    }

    /// <summary>
    /// ConcreteBuilder for HighSpeedNotebook
    /// </summary>
    public class HighSpeedNotebook : INotebookBuilder
    {
        public DisplayEnvironment BuildDisplayEnvironment()
        {
            return new DisplayEnvironment() { GraphicCard = "High Speed Graphic Card", ScreenResolution = "1248 x 1200", ScreenWide = "17''" };
        }

        public OEMEnvironment BuildOEMEnvironment()
        {
            return new OEMEnvironment() { Processor = "High Speed Processor" };
        }
    }

    /// <summary>
    /// Director Class
    /// </summary>
    public class BuilderDirector
    {
        private INotebookBuilder Builder;
        public BuilderDirector(INotebookBuilder builder)
        {
            Builder = builder;
        }

        public NotebookProduct BuildNotebook()
        {
            NotebookProduct product = new NotebookProduct();
            product.ProductDisplayEnvironment = Builder.BuildDisplayEnvironment();
            product.ProductOEMEnvironment = Builder.BuildOEMEnvironment();
            return product;
        }

    }
}

