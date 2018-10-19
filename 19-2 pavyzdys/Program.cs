using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_2_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            var skaicius = p.BetKoksSkaicius();
            Console.WriteLine(skaicius);
        }

        public int BetKoksSkaicius()
        {
            var rand = new Random();
            return rand.Next(100);
        }
    }
}
