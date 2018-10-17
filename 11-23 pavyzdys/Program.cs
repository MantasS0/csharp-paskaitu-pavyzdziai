using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_23_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] {4, 2, 3, 5, 1, 9};

            var min = skaiciai.Min();
            var max = skaiciai.Max();

            Console.WriteLine("maziausias: " + min);
            Console.WriteLine("didziausias: " + max);
        }
    }
}
