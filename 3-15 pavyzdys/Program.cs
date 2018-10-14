using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_15_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 2;
            var penktasLaipsnis = Math.Pow(skaicius, 5);

            Console.WriteLine("skaicius: " + skaicius);
            Console.WriteLine("penktas laipsnis: " + penktasLaipsnis);
        }
    }
}
