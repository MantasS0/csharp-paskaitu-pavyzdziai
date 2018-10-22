using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_9_pavyzdys
{
    class Automobiliai
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

        public void Isvedimas()
        {
            Console.WriteLine("{0, -12} {1, -12} {2, -12} {3, -12} {4, -12} {5, -12}",
                "Marke", "Modelis", "Rida, km", "Metai", "D. turis l.", "Kuro tipas");

            foreach (var auto in AutomobiliuSarasas)
            {
                auto.Spausdinti();
            }

            Console.WriteLine();
            
            Console.WriteLine("Naujausias automobilis");
            NaujausiasAutomobilis().Spausdinti();

            Console.WriteLine("Didziausia rida");
            var didziausiaRida = DidziausiaRida();
            didziausiaRida.Spausdinti();

            Console.WriteLine("Maziausias darbinis turis");
            MaziausiasDarbinisTuris().Spausdinti();

            Console.WriteLine();
        }

        public Automobilis NaujausiasAutomobilis()
        {
            var naujausias = AutomobiliuSarasas.First();

            foreach (var auto in AutomobiliuSarasas)
            {
                if (!naujausias.SitasNaujesnis(auto))
                {
                    naujausias = auto;
                }
            }

            return naujausias;
        }

        public Automobilis DidziausiaRida()
        {
            var didziausia = AutomobiliuSarasas.First();

            foreach (var auto in AutomobiliuSarasas)
            {
                if (auto.Rida > didziausia.Rida)
                {
                    didziausia = auto;
                }
            }

            return didziausia;
        }

        public Automobilis MaziausiasDarbinisTuris()
        {
            var maziausias = AutomobiliuSarasas.First();

            foreach (var auto in AutomobiliuSarasas)
            {
                if (auto.DarbinisTuris < maziausias.DarbinisTuris)
                {
                    maziausias = auto;
                }
            }

            return maziausias;
        }
    }
}
