using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 1;

            while (true)
            {
                if (skaicius >= 5)
                {
                    break;
                }

                Console.WriteLine(skaicius);
                skaicius++;
            }
        }
    }
}
