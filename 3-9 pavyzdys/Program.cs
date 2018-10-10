using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_9_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var pirmas = 9;
            var antras = 4;

            Console.WriteLine(pirmas + " + " + antras + " = " + pirmas + antras);
            Console.WriteLine(pirmas + " + " + antras + " = " + (pirmas + antras));

            Console.WriteLine("{0} + {1} = {2}", pirmas, antras, pirmas + antras);

            var suma = pirmas + antras;
            Console.WriteLine("{0} + {1} = {2}", pirmas, antras, suma);
        }
    }
}
