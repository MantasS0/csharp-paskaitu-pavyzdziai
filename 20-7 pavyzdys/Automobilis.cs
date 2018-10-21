using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_7_pavyzdys
{
    class Automobilis
    {
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Rida { get; set; }
        public int Metai { get; set; }
        public double DarbinisTuris { get; set; }

        public Automobilis(string marke, string modelis, int rida, int metai, double darbinisTuris)
        {
            Marke = marke;
            Modelis = modelis;
            Rida = rida;
            Metai = metai;
            DarbinisTuris = darbinisTuris;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Automobilis {0} {1} ({2} m.) nuvaziavo {3} km, jo darbinis turis {4} l.",
                Marke, Modelis, Metai, Rida, DarbinisTuris);
        }

        public bool SitasNaujesnis(Automobilis kitas)
        {
            if (Metai > kitas.Metai)
            {
                return true;
            }

            return false;
        }
    }
}
