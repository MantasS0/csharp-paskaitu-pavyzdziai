using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_5_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite savaites diena: ");
            var diena = Console.ReadLine();

            switch (diena)
            {
                case "sestadienis":
                case "sekmadienis":
                    Console.WriteLine("savaitgalis!");
                    break;
                default:
                    Console.WriteLine("darbo diena :(");
                    break;
            }
        }
    }
}
