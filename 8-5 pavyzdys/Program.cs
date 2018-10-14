using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                    Console.WriteLine("skaicius {0} dalinasi is 2 arba 5", i);
                }
            }
        }
    }
}
