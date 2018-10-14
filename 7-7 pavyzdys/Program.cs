using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pasirinkite");
            Console.WriteLine("1 - jeigu x priezastis");
            Console.WriteLine("2 - jeigu y priezastis");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("pasirinktas pirmas variantas");
                    Console.WriteLine("cia siek tiek daugiau veiksmu");
                    Console.WriteLine("kas susije su pirmu pasirinkimu");
                    break;
                case 2:
                    Console.WriteLine("pasirinktas antras variantas");
                    Console.WriteLine("iveskite skaiciu");
                    var skaicius = Convert.ToInt32(Console.ReadLine());
                    if (skaicius > 0)
                    {
                        Console.WriteLine("skaicius teigiamas");
                    }
                    break;
                default:
                    Console.WriteLine("tokio pasirinkimo varianto nera");
                    break;
            }
        }
    }
}
