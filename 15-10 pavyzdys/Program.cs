using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_10_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new List<int>();

            skaiciai.Add(7);
            skaiciai.Add(8);
            skaiciai.Add(3);
            skaiciai.Add(2);

            Console.WriteLine("suma: " + skaiciai.Sum());
            Console.WriteLine("vidurkis: " + skaiciai.Average());
            Console.WriteLine("maziausias: " + skaiciai.Min());
            Console.WriteLine("didziausias: " + skaiciai.Max());
            Console.WriteLine("skaiciu kiekis: " + skaiciai.Count);
            Console.WriteLine("pirmas: " + skaiciai.First());
            Console.WriteLine("paskutinis: " + skaiciai.Last());
            // ...
        }
    }
}
