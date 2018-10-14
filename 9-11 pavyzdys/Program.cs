using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_11_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pasirinkite");
            Console.WriteLine("1 - jei x priezastis");
            Console.WriteLine("2 - jei y priezastis");
            Console.WriteLine("3 - jei z priezastis");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            while (pasirinkimas != 1 && pasirinkimas != 2 && pasirinkimas != 3)
            {
                Console.WriteLine("blogas pasirinkimas, bandykite dar karta");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("pasirinkta: " + pasirinkimas);
        }
    }
}
