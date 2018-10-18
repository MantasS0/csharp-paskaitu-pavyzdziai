using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_11_pvyzdys
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
                var skaicius = rand.Next(100);
                skaiciai.Add(skaicius);
            }

            foreach (var skaicius in skaiciai)
            {
                Console.Write(skaicius + " ");
            }

            Console.WriteLine();
        }
    }
}
