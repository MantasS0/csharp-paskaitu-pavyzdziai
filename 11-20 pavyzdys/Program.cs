using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_20_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] {4, 7, 5, 3, 6, 5};

            var suma = skaiciai.Sum();
            var vidurkis = skaiciai.Average();

            Console.WriteLine("suma: " + suma);
            Console.WriteLine("vidurkis: " + vidurkis);
        }
    }
}
