using System.Security.Authentication.ExtendedProtection;

namespace _2m_14_Figura
{
    class Figura
    {
        protected string nazwa;
        public Figura(string nazwa)
        {
            this.nazwa = nazwa;
        }
        public override string ToString()
        {
            return $"{nazwa}";
        }
    }
    class Prostokat : Figura
    {
        private double bokA, bokB;
        public double pole { get { return bokA*bokB; } }
        public Prostokat(string nazwa,  double bokA, double bokB) :base(nazwa)
        {
            this.bokA = bokA;
            this.bokB = bokB;
        }
        public override string ToString()
        {
            return $"{nazwa} bok: {bokA}; bok: {bokB}";
        }

    }


    class Kanapka
    {
        private string _nazwa = "kanapka";
        public virtual string nazwa { get { return _nazwa; } }
    }
    class KanapkaZSerem : Kanapka
    {
        private string _nazwa = "kanapka z serem";
        public override string nazwa { get { return _nazwa; } }
    }


    internal class Program
    {
        public static void pokazKanapke(Kanapka k)
        {
            Console.WriteLine(k.nazwa);
        }
        static void Main(string[] args)
        {
            Kanapka k1 = new Kanapka();
            KanapkaZSerem k2 = new KanapkaZSerem();

            pokazKanapke(k1);
            pokazKanapke(k2);

            Kanapka k3 = k2;
           // KanapkaZSerem k4 = (KanapkaZSerem)k1;

            /*
            Prostokat p1 = new Prostokat("prostokąt", 4, 5);
            Console.WriteLine(p1);
            */
        }
    }
}