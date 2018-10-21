using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_5_pavyzdys
{
    class Zmogus
    {
        public string Vardas;
        public string Pavarde;
        public int Amzius;
        public double Ugis;

        public Zmogus(string vardas, string pavarde, int amzius, double ugis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Ugis = ugis;
        }

        public void Informacija()
        {
            Console.WriteLine(Vardas + " " + Pavarde + " " + Amzius + " " + Ugis);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var zmogus = new Zmogus("Gabriele", "Gabryte", 18, 1.6);
            zmogus.Informacija();
        }
    }
}
