using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_24_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 123;

            if (skaicius % 2 == 0)
            {
                Console.WriteLine("skaicius dalinasi is 2");
            }
            else if (skaicius % 3 == 0)
            {
                Console.WriteLine("skaicius dalinasi is 3");
            }
            else if (skaicius % 4 == 0)
            {
                Console.WriteLine("skaicius dalinasi is 4");
            }
            else
            {
                Console.WriteLine("skaicius is nieko nesidalina");
            }
        }
    }
}
