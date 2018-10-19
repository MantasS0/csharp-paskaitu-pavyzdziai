using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            var vardas = "Povilas";
            var amzius = 20;

            p.Informacija(vardas, amzius);
            p.Informacija(vardas, 25);
            p.Informacija("Paulius", amzius);
            p.Informacija("Giedrius", 18);
        }

        public void Informacija(string vard, int amz)
        {
            Console.WriteLine(vard + " " + amz);
        }
    }
}
