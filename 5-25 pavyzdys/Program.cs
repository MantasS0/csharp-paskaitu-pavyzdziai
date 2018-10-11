using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_25_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardas = "Petras";

            if (vardas == "Jonas")
            {
                Console.WriteLine("labas, Jonai");
            }
            else if (vardas == "Tomas")
            {
                Console.WriteLine("labas, Tomai");
            }
            else
            {
                Console.WriteLine("labas, kad ir kas tu esi");
            }
        }
    }
}
