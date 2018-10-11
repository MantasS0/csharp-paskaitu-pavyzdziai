using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_22_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var pirmas = 7;
            var antras = 9;

            if (pirmas > antras)
            {
                Console.WriteLine("{0} yra didesnis uz {1}", pirmas, antras);
            }
            else
            {
                Console.WriteLine("skaiciai yra lygus arba {0} yra mazesnis uz {1}",
                    pirmas, antras);
            }
        }
    }
}
