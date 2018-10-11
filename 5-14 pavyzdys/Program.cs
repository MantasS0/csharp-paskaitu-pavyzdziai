using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_14_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite marke");
            var marke = Console.ReadLine();

            Console.WriteLine("iveskite modeli");
            var modelis = Console.ReadLine();

            Console.WriteLine("iveskite gamybos metus");
            var metai = Convert.ToInt32(Console.ReadLine());

            if (2018 - metai < 5)
            {
                Console.WriteLine("automobilis {0} {1} yra naujesnis nei 5 metu",
                    marke, modelis);
            }
        }
    }
}
