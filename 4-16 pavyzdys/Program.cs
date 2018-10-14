using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_16_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ar testi programos darba? (t/n)");
            var pasirinkimas = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("pasirinkta: " + pasirinkimas);
        }
    }
}
