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
    class P2 : Prostokat
    {
        public override string ToString()
        {
            return $"{nazwa}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostokat p1 = new Prostokat("prostokąt", 4, 5);
            Console.WriteLine(p1);
        }
    }
}