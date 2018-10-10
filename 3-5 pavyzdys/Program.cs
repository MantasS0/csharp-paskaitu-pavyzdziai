using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var pirmas = 7;
            var antras = 3;

            var atsakymas1 = pirmas / antras;
            var atsakymas2 = (double)pirmas / antras;

            Console.WriteLine(atsakymas1);
            Console.WriteLine(atsakymas2);
        }
    }
}
