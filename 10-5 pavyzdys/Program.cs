using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 20;

            do
            {
                if (skaicius % 3 == 0)
                {
                    Console.WriteLine("skaicius {0} dalinasi is 3", skaicius);
                }
                else
                {
                    Console.WriteLine(skaicius);
                }
                skaicius--;
            } while (skaicius > 0);
        }
    }
}
