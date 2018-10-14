using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 1;

            do
            {
                Console.WriteLine(skaicius);
                skaicius++;
            } while (skaicius % 15 != 0);
        }
    }
}
