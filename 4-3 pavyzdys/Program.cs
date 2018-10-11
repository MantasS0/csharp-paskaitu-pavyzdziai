using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite marke: ");
            var marke = Console.ReadLine();

            Console.Write("Iveskite modeli: ");
            var modelis = Console.ReadLine();

            Console.WriteLine("ivesta marke ir modelis: {0} {1}", marke, modelis);
        }
    }
}
