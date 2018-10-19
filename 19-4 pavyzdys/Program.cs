using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_4_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            Console.WriteLine(p.BetKoksSkaiciusBlogai(10, 100));
            Console.WriteLine(p.BetKoksSkaiciusBlogai(10, 100));
            Console.WriteLine(p.BetKoksSkaiciusBlogai(10, 100));
            Console.ReadLine();

            var rand = new Random();

            Console.WriteLine(p.BetKoksSkaiciusGerai(rand, 10, 100));
            Console.WriteLine(p.BetKoksSkaiciusGerai(rand, 10, 100));
            Console.WriteLine(p.BetKoksSkaiciusGerai(rand, 10, 100));
        }

        public int BetKoksSkaiciusBlogai(int nuo, int iki)
        {
            var rand = new Random();
            return rand.Next(nuo, iki);
        }

        public int BetKoksSkaiciusGerai(Random rand, int nuo, int iki)
        {
            return rand.Next(nuo, iki);
        }
    }
}
