using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_9_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var pirmas = -5;
            var antras = 4;

            if (pirmas + 7 > 0)
            {
                Console.WriteLine("prie {0} pridejus 7, jis yra teigiamas", pirmas);
            }

            if (antras * 2 > 10)
            {
                Console.WriteLine("skaiciu {0} padauginus is 2 jis yra didesnis nei 10", antras);
            }
        }
    }
}
