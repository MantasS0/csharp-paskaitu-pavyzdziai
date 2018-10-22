using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_9_pavyzdys
{
    class Automobilis
    {
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Rida { get; set; }
        public int Metai { get; set; }
        public double DarbinisTuris { get; set; }
        public string KuroTipas { get; set; }

        public Automobilis(string marke, string modelis, int rida, int metai, double darbinisTuris, string kuroTipas)
        {
            Marke = marke;
            Modelis = modelis;
            Rida = rida;
            Metai = metai;
            DarbinisTuris = darbinisTuris;
            KuroTipas = kuroTipas;
        }

        public Automobilis(string eilute)
        {
            var duomenys = eilute.Split(';');
            Marke = duomenys[0];
            Modelis = duomenys[1];
            Rida = Convert.ToInt32(duomenys[2]);
            Metai = Convert.ToInt32(duomenys[3]);
            DarbinisTuris = Convert.ToDouble(duomenys[4]);
            KuroTipas = duomenys[5];
        }

        public void Spausdinti()
        {
            Console.WriteLine("{0, -12} {1, -12} {2, -12} {3, -12} {4, -12} {5, -12}",
                Marke, Modelis, Rida, Metai, DarbinisTuris, KuroTipas);
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
