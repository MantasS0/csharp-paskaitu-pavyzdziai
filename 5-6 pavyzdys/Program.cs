using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var zodis = "suo";

            if (zodis == "Suo")
            {
                Console.WriteLine("Suo");
            }

            if (zodis == "suo")
            {
                Console.WriteLine("suo");
            }

            if (zodis == "SUO")
            {
                Console.WriteLine("SUO");
            }
        }
    }
}
