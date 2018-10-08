using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_13_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var marke = "wttt";
            var modelis = "adhf";
            var metai = 1999;
            var rida = 345214;

            Console.Write("Automobilio " + marke + " " + modelis + " ");
            Console.Write("(" + metai + " m.) ");
            Console.WriteLine("rida yra " + rida + " km.");
        }
    }
}
