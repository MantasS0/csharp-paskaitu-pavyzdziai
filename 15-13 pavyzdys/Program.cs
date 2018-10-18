using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_13_pavyzdys
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

            for (int i = 0; i < skaiciai.Count; i++)
            {
                Console.Write("[{0}] ", skaiciai[i]);
            }

            Console.WriteLine();
        }
    }
}
