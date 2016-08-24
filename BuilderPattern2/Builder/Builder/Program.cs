using System;

namespace Builder
{
    // Product class
    public class Pizza
    {
        public string PizzaTipi { get; set; }
        public string Hamur { get; set; }
        public string Sos { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", PizzaTipi, Hamur, Sos);
        }
    }

    // Builder class
    public abstract class PizzaBuilder
    {
        protected Pizza _pizza;

        public Pizza Pizza
        {
            get { return _pizza; }
        }

        public abstract void SosuHazirla();
        public abstract void HamuruHazirla();
    }

    // ConcreteBuilder class
    public class BaharatliPizzaBuilder
        : PizzaBuilder
    {
        public BaharatliPizzaBuilder()
        {
            _pizza = new Pizza { PizzaTipi = "Baharatlı Baharatlı" };
        }
        public override void SosuHazirla()
        {
            _pizza.Sos = "Acı sos, pepperoni, atom biber";
        }

        public override void HamuruHazirla()
        {
            _pizza.Hamur = "İnce Kenar, Kaşarlı";
        }
    }

    // ConcreteBuilder Class
    public class DortMevsimPizzaBuilder
        : PizzaBuilder
    {
        public DortMevsimPizzaBuilder()
        {
            _pizza = new Pizza { PizzaTipi = "4 Mevsim" };
        }
        public override void SosuHazirla()
        {
            _pizza.Sos = "Biber, Domates, Peynir, Salam, Sosis";
        }

        public override void HamuruHazirla()
        {
            _pizza.Hamur = "Kalın, fesleğenli";
        }
    }

    // Director Class
    public class VedenikliKamil
    {
        public void Olustur(PizzaBuilder vBuilder)
        {
            vBuilder.SosuHazirla();
            vBuilder.HamuruHazirla();
        }
    }

    // Client class
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder vBuilder;

            VedenikliKamil kamil = new VedenikliKamil();
            vBuilder = new BaharatliPizzaBuilder();
            
            kamil.Olustur(vBuilder);
            Console.WriteLine(vBuilder.Pizza.ToString());

            vBuilder = new DortMevsimPizzaBuilder();
            kamil.Olustur(vBuilder);
            Console.WriteLine(vBuilder.Pizza.ToString());
            Console.ReadLine();
        }
    }
}
