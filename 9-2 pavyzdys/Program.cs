using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var kiekis = 10;
            Random atsitiktinis = new Random();

            while (kiekis >= 0)
            {
                Console.WriteLine("turimus kiekis: " + kiekis);
                kiekis -= atsitiktinis.Next(1, 3);
            }
        }
    }
}
