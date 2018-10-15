using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_10_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var zodziai = new[]
            {
                "medis",
                "gulbe",
                "burundukas",
                "kelmas"
            };

            foreach (var zodis in zodziai)
            {
                Console.Write(zodis + ", ");
            }

            Console.WriteLine();
        }
    }
}
