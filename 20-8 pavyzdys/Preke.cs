using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_8_pavyzdys
{
    class Preke
    {
        public string Pavadinimas { get; set; }
        public double Savikaina { get; set; }
        public double Kaina { get; set; }
        public string Kodas { get; set; }

        public Preke(string pavadinimas, double savikaina, double kaina, string kodas)
        {
            Pavadinimas = pavadinimas;
            Savikaina = savikaina;
            Kaina = kaina;
            Kodas = kodas;
        }

        public void Isvedimas()
        {
            Console.WriteLine("| {0, -15} | {1, -5} | {2, -5} | {3, -10} |",
                Pavadinimas, Savikaina, Kaina, Kodas);
        }

        public double Pelnas()
        {
            return Kaina - Savikaina;
        }
    }
}

