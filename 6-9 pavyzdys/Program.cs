using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_9_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite skaiciu: ");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            if ((skaicius > 0 && skaicius < 100) || skaicius % 2 == 0)
            {
                Console.WriteLine("skaicius patenka i rezius arba dalinasi is 2");
            }

            if (skaicius > 0 && (skaicius < 100 || skaicius % 2 == 0))
            {
                Console.WriteLine("skaicius mazesnis nei 100 arba lyginis ir yra teigiamas");
            }
        }
    }
}
