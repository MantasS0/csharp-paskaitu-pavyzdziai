using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_8_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var skaicius = 0;

            while (skaicius < 10)
            {
                Console.WriteLine(skaicius);
                skaicius = rand.Next(1, 15);
            }
        }
    }
}
