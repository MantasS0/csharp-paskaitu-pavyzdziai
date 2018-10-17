using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_13_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] {4, 5, 8, 3, 4, 1};
            Console.WriteLine("pirmas skaicius: " + skaiciai.First());
            Console.WriteLine("paskutinis skaicius: " + skaiciai.Last());
            Console.Write("skaiciai: ");

            foreach (var skaicius in skaiciai)
            {
                Console.Write(skaicius + " ");
            }

            Console.WriteLine();
            Console.WriteLine("maziausias: " + skaiciai.Min());
            Console.WriteLine("didziausias: " + skaiciai.Max());
            Console.WriteLine("suma: " + skaiciai.Sum());
            Console.WriteLine("vidurkis: " + skaiciai.Average());
            //...
        }
    }
}
