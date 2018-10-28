using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_10_24_2
{
    public class Automobiliai
    {
        public List<Automobilis> AutomobiliuSarasas { get; set; }

        public Automobiliai(List<Automobilis> automobiliuSarasas)
        {
            AutomobiliuSarasas = automobiliuSarasas;
        }

        public Automobiliai(string failas)
        {
            var tekstas = File.ReadAllLines(failas);
            AutomobiliuSarasas = new List<Automobilis>();

            for (int i = 1; i < tekstas.Length; i++)
            {
                var auto = new Automobilis(tekstas[i]);
                AutomobiliuSarasas.Add(auto);
            }
        }

        public Automobilis Naujausias()
        {
            var naujausias = AutomobiliuSarasas.First();

            foreach (var auto in AutomobiliuSarasas)
            {
                if (auto.Metai > naujausias.Metai)
                {
                    naujausias = auto;
                }
            }

            return naujausias;
        }

        public Automobilis DidziausiosRidos()
        {
            var didziausiosRidos = AutomobiliuSarasas.First();

            foreach (var auto in AutomobiliuSarasas)
            {
                if (auto.Rida > didziausiosRidos.Rida)
                {
                    didziausiosRidos = auto;
                }
            }

            return didziausiosRidos;
        }
    }
}
