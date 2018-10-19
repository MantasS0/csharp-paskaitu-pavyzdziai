using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_8_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var rand = new Random();

            var skaiciai = p.GeneruotiSkaicius(rand, 10, 10, 15);

            p.Isvesti(skaiciai);
            p.Isvesti(p.GeneruotiSkaicius(rand, 5, 10, 100));
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

        public void Isvesti(List<int> skaiciai)
        {
            Console.Write("skaiciai is saraso: ");

            foreach (var i in skaiciai)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
