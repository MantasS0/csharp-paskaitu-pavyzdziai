using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            while (true)
            {
                var skaicius = rand.Next(1, 100);
                Console.WriteLine(skaicius);

                if (skaicius % 2 == 0 && skaicius % 7 == 0)
                {
                    Console.WriteLine("skaicius {0} dalinasi is 2 ir is 7", skaicius);
                    break;
                }
            }
        }
    }
}
