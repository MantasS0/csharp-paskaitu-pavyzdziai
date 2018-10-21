using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_7_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var automobiliai = new List<Automobilis>
            {
                new Automobilis("RTyuj", "ssgh", 25545, 2016, 1.2),
                new Automobilis("sbajfbdjgb", "HUhsbgdg", 8487879, 1980, 2.0),
                new Automobilis("JHsjbg", "shhdg", 54889, 2015, 1.6),
                new Automobilis("Pajd", "hVGvgv", 54878, 2010, 1.8)
            };

            var p = new Program();

            p.SpausdintiVisus(automobiliai);

            var naujausias = p.NaujausiasAuto(automobiliai);
            Console.WriteLine("Naujausias auto:");
            naujausias.Isvedimas();
        }

        public void SpausdintiVisus(List<Automobilis> automobiliai)
        {
            foreach (var auto in automobiliai)
            {
                auto.Isvedimas();
            }
        }

        public Automobilis NaujausiasAuto(List<Automobilis> automobiliai)
        {
            var naujausias = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (!naujausias.SitasNaujesnis(auto))
                {
                    naujausias = auto;
                }
            }

            return naujausias;
        }
    }
}
