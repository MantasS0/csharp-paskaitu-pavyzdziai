using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_21_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite gyvuna: ");
            var gyvunas = Console.ReadLine();

            if (gyvunas == "zirafa")
            {
                Console.WriteLine("oho");
            }
            else
            {
                Console.WriteLine("turimas gyvunas: " + gyvunas);
            }
        }
    }
}
