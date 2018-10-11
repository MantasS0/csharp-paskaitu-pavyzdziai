using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 5;

            if (skaicius > 5)
            {
                Console.WriteLine(skaicius + " > 5");
            }

            if (skaicius >= 5)
            {
                Console.WriteLine(skaicius + " >= 5");
            }

            if (skaicius == 5)
            {
                Console.WriteLine(skaicius + " == 5");
            }
        }
    }
}
