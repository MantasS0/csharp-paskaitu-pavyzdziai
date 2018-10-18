using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_12_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random(); // atsitiktiniu skaiciu generavimui
            var skaiciai = new List<int>(); // visi skaiciai
            var kiek = 10; // kiek atsitiktiniu skaiciu generuoti

            for (int i = 0; i < kiek; i++)
            {
                skaiciai.Add(rand.Next(100));
            }

            foreach (var skaicius in skaiciai)
            {
                Console.Write("[{0}] ", skaicius);
            }

            Console.WriteLine();
        }
    }
}
