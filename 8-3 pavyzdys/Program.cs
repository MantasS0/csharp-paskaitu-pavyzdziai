using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i <= 50; i += 5)
            {
                Console.Write("[{0}] ", i);
            }

            Console.WriteLine();
        }
    }
}
