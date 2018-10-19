using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_9_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var rand = new Random();

            Console.Write("Kiek skaiciu norite sugeneruoti? ");
            var kiek = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skaiciai turi buti nuo: ");
            var nuo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skaiciai turi buti iki: ");
            var iki = Convert.ToInt32(Console.ReadLine());

            var sugeneruoti = p.GeneruotiSkaicius(rand, kiek, nuo, iki);

            Console.WriteLine("Sugeneruoti skaiciai:");
            p.Spausdinti(sugeneruoti);
        }

        public List<int> GeneruotiSkaicius(Random rand, int kiek, int nuo, int iki)
        {
            var skaiciai = new List<int>();

            for (int i = 0; i < kiek; i++)
            {
                skaiciai.Add(rand.Next(nuo, iki));
            }

            return skaiciai;
        }

        public void Spausdinti(List<int> skaiciai)
        {
            foreach (var i in skaiciai)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
