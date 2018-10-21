using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_4_pavyzdys
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            var zmogus = new Zmogus("Petras", "Petrauskas", 55, 1.8);

            Console.WriteLine(zmogus.Vardas);
            Console.WriteLine(zmogus.Pavarde);
            Console.WriteLine(zmogus.Amzius);
            Console.WriteLine(zmogus.Ugis);
        }
    }
}
