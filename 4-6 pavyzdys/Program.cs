using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite pirma skaiciu: ");
            var pirmas = Convert.ToInt32(Console.ReadLine());

            Console.Write("iveskite antra skaiciu: ");
            var antras = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("jus ivedete {0} ir {1} skaicius", pirmas, antras);
        }
    }
}
