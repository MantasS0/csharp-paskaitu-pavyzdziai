using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu, kuris patektu i rezius [1-100]");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius < 0 || skaicius > 100)
            {
                Console.WriteLine("blogai ivestas skaicius");
                Console.WriteLine("bandykite dar karta");
                skaicius = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("ivestas skaicius: " + skaicius);
        }
    }
}
