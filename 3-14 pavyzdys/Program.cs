using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_14_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 5;

            Console.WriteLine("skaicius: " + skaicius);

            skaicius -= 3;
            Console.WriteLine("-= 3: " + skaicius);

            skaicius *= 2;
            Console.WriteLine("*= 2: " + skaicius);

            skaicius += 7;
            Console.WriteLine("+= 7: " + skaicius);

            skaicius /= 2;
            Console.WriteLine("/= 2: " + skaicius);
        }
    }
}
