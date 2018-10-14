using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_11_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 7; i++)
            {
                if (i == 2 || i == 4)
                {
                    continue; // grizta i ciklo pradzia
                }

                Console.WriteLine(i);
            }
        }
    }
}
