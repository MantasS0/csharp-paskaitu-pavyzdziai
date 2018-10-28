using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_10_24_2
{
    public class Automobilis
    {
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Rida { get; set; }
        public int Metai { get; set; }
        public double DarbinisTuris { get; set; }
        public string KuroTipas { get; set; }

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
    }
}
