using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_18_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] {4, 7, 8, 3, 6, 5, 2, 1, 8, 9};
            var suma = 0;

            foreach (var sk in skaiciai)
            {
                suma += sk;
            }

            Console.WriteLine("skaiciu suma: " + suma);
        }
    }
}
