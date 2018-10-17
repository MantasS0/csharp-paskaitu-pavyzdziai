using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_19_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] {4, 2, 5, 8, 3, 0, 1, -4, 8, 9, 7, 5};
            var suma = 0;

            foreach (var sk in skaiciai)
            {
                suma += sk;
            }

            var vidurkis = (double) suma / skaiciai.Length;
            Console.WriteLine("vidurkis: " + vidurkis);
        }
    }
}
