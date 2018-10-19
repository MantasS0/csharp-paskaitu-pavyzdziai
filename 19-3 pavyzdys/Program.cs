using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_3_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            Console.WriteLine(p.BetKoksSkaicius(4, 10));

            var skaicius = p.BetKoksSkaicius(8, 10);
            Console.WriteLine(skaicius);
        }

        public int BetKoksSkaicius(int nuo, int iki)
        {
            var rand = new Random();
            return rand.Next(nuo, iki);
        }
    }
}
