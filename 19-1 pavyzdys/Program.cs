using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_1_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine(p.BetKoksSkaicius());
        }

        public int BetKoksSkaicius()
        {
            var rand = new Random();
            var skaicius = rand.Next(100);
            return skaicius;
        }
    }
}
