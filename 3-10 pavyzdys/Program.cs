using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_10_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius1 = 5;
            var skaicius2 = 6;

            var suma = skaicius1 + skaicius2;
            var skirtumas = skaicius1 - skaicius2;
            var sandauga = skaicius1 * skaicius2;
            var dalmuo = (double)skaicius1 / skaicius2;

            Console.WriteLine("{0} + {1} = {2}", skaicius1, skaicius2, suma);
            Console.WriteLine("{0} - {1} = {2}", skaicius1, skaicius2, skirtumas);
            Console.WriteLine("{0} * {1} = {2}", skaicius1, skaicius2, sandauga);
            Console.WriteLine("{0} / {1} = {2}", skaicius1, skaicius2, dalmuo);
        }
    }
}
