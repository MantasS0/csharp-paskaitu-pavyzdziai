using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius > 0 && skaicius % 2 == 0)
            {
                Console.WriteLine("skaicius yra teigiamas ir lyginis");
            }
            else if (skaicius > 0 && skaicius % 3 == 0)
            {
                Console.WriteLine("skaicius yra teigiamas ir dalinasi is 3");
            }
            else
            {
                Console.WriteLine("skaicius neigiamas arba nesidalina nei is 2 nei is 3");
            }
        }
    }
}
