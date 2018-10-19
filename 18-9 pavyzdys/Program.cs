using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_9_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            var pirmas = new[] {4, 7, 8, 5, 3};
            var antras = new[] {5, 8, 2, 1, 4, 7, 9, 3};

            p.Isvedimas(pirmas);
            p.Isvedimas(antras);
        }

        public void Isvedimas(int[] skaiciai)
        {
            Console.WriteLine("MASYVO SKAICIAI");

            foreach (var skaicius in skaiciai)
            {
                Console.Write("[{0}]", skaicius);
            }

            Console.WriteLine("\n");
        }
    }
}
