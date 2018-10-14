using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_4_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite sviesoforo spalva: ");
            var sviesoforas = Console.ReadLine();

            switch (sviesoforas)
            {
                case "zalia":
                    Console.WriteLine("galite vaziuoti");
                    break;
                case "geltona":
                    Console.WriteLine("turetum sustoti");
                    break;
                case "raudona":
                    Console.WriteLine("privalai sustoti");
                    break;
                default:
                    Console.WriteLine("kazkoks keistas sviesoforas");
                    break;
            }
        }
    }
}
