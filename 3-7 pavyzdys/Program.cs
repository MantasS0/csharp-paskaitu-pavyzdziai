using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_7_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var pirmas = 7;
            var antras = 3;
            var dalmuo = (double)pirmas / antras;
            var liekana = pirmas % antras;

            Console.WriteLine("dalmuo: " + dalmuo);
            Console.WriteLine("liekana: " + liekana);
        }
    }
}
