using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            if (5 + 3 > 0 || 100 < 100)
            {
                Console.WriteLine("pirmas if");
            }

            if (8 * 2 == 16 && (8 + 9 * 2) % 2 == 0)
            {
                Console.WriteLine("antras if");
            }

            if (true && true)
            {
                Console.WriteLine("trecias if");
            }

            if (true || false)
            {
                Console.WriteLine("ketvirtas if");
            }
        }
    }
}
