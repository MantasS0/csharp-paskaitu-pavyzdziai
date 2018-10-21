using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_11_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Informacija();
            p.Klaidinga();
        }

        public void Informacija()
        {
            var vardas = "Gabriele";
            var amzius = 25;
            Console.WriteLine("{0} ({1} m.)", vardas, amzius);
        }

        public void Klaidinga()
        {
            Console.WriteLine(vardas);
        }
    }
}
