using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("skaicius {0} yra lyginis", i);
                }
            }
        }
    }
}
