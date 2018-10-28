using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_10_2018_10_23_1
{
    class Lektuvas
    {
        public int SparnuIlgis;
        public string Pavadinimas;
        public int Vietos;
        public string Klase;
        public int VarikliuSkaicius;
        public string VariklioTipas;

        public Lektuvas() { }

        public Lektuvas(int SparnuIlgis, string pavadinimas, int vietos,
            string klase, int varikliuSkaicius, string variklioTipas)
        {
            this.SparnuIlgis = SparnuIlgis; // this rodo i klase
            Pavadinimas = pavadinimas;
            Vietos = vietos;
            Klase = klase;
            VarikliuSkaicius = varikliuSkaicius;
            VariklioTipas = variklioTipas;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Lektuvas {0} turi {1} vietu, jo sparnu ilgis yra {2} metru.",
                Pavadinimas, Vietos, SparnuIlgis);
            Console.WriteLine("Jis priskiriamas {0} klasei, turi {1} tipo {2} variklius.",
                Klase, VariklioTipas, VarikliuSkaicius);
            Belekaaaa();
            Console.WriteLine("Sparno ilgis: " + SparnoIlgis());
            Console.WriteLine();
        }

        public void Belekaaaa()
        {
            Console.WriteLine("vieno sparno ilgis: " + SparnuIlgis / 2);
        }

        public int SparnoIlgis()
        {
            return SparnuIlgis / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var lektuvas1 = new Lektuvas();
            var lektuvas2 = new Lektuvas();

            lektuvas1.Pavadinimas = "Boeying";
            lektuvas1.Vietos = 600;
            lektuvas1.Klase = "Tarpatlantinis";
            lektuvas1.SparnuIlgis = 500;
            lektuvas1.VariklioTipas = "Turbo";
            lektuvas1.VarikliuSkaicius = 4;

            lektuvas2.Pavadinimas = "Kukuruzninkas";
            lektuvas2.Vietos = 1;
            lektuvas2.Klase = "Ukinis";
            lektuvas2.SparnuIlgis = 2;
            lektuvas2.VariklioTipas = "Reaktyvinis";
            lektuvas2.VarikliuSkaicius = 1;

            Console.WriteLine(lektuvas1.Pavadinimas);
            Console.WriteLine(lektuvas2.SparnuIlgis);
            Console.WriteLine(lektuvas1.Klase);
            Console.WriteLine(lektuvas2.VariklioTipas);
            Console.WriteLine();

            lektuvas1.Isvedimas();
            lektuvas2.Isvedimas();

            lektuvas1.Belekaaaa();
            lektuvas2.Belekaaaa();

            Console.WriteLine(lektuvas1.SparnoIlgis());
            Console.WriteLine(lektuvas2.SparnoIlgis());

            var lektuvas3 = new Lektuvas(5, "F15", 2, "Naikintuvas", 2, "Reaktyvinis");
            lektuvas3.Isvedimas();
        }
    }
}
