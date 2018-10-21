using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_2_pavyzdys
{
    class Automobilis
    {
        public string Marke;
        public string Modelis;
        public int Rida;
        public int Metai;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var auto = new Automobilis();

            auto.Marke = "Kazkokia";
            auto.Modelis = "Aikazinau";
            auto.Rida = 23000;
            auto.Metai = 2016;

            Console.WriteLine("{0} {1} pagamintas {2} metais ir nuvaziavo {3} km.", 
                auto.Marke, auto.Modelis, auto.Metai, auto.Rida);
        }
    }
}
