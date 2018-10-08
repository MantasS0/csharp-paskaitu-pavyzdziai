using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_17_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var marke = "ahd";
            var modelis = "afdsg";
            var metai = 2016;
            var rida = 78452;

            Console.WriteLine("automobilio {0} {1} ({2} m.) rida yra {3} km.", marke, modelis, metai, rida);
        }
    }
}
