using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_11_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 8;

            if (skaicius % 2 != 0)
            {
                Console.WriteLine("skaicius {0} nesidalina is 2", skaicius);
            }

            if (skaicius % 3 != 0)
            {
                Console.WriteLine("skaicius {0} nesidalina is 3", skaicius);
            }

            if (skaicius % 4 != 0)
            {
                Console.WriteLine("skaicius {0} nesidalina is 4", skaicius);
            }
        }
    }
}
