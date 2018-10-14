using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_8_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var pasirinkimas = 0;

            do
            {
                Console.WriteLine("pasirinkite");
                Console.WriteLine("1 - x dalykas");
                Console.WriteLine("2 - y dalykas");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());

                if (pasirinkimas != 1 && pasirinkimas != 2)
                {
                    Console.WriteLine("blogai ivestas skaicius");
                }
            } while (pasirinkimas != 1 && pasirinkimas != 2);

            Console.WriteLine("pasirinkimas: " + pasirinkimas);
        }
    }
}
