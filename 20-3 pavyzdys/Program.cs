using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_3_pavyzdys
{
    class Automobilis
    {
        public string Marke;
        public string Modelis;
        public int Metai;
        public int Rida;

        public void Spausdinti()
        {
            Console.WriteLine("{0} {1} pagamintas {2} metais, nuvaziavo {3} km.",
                Marke, Modelis, Metai, Rida);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var auto = new Automobilis();

            auto.Marke = "Markee";
            auto.Modelis = "Bahahaha";
            auto.Metai = 2018;
            auto.Rida = 1000;

            auto.Spausdinti();
        }
    }
}
