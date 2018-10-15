using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var zodziai = new []
            {
                "lapas",
                "gele",
                "medis",
                "kamuolys"
            };

            Console.WriteLine(zodziai[1]);
            Console.WriteLine(zodziai[3]);
            Console.WriteLine(zodziai[0]);
            Console.WriteLine(zodziai[2]);
        }
    }
}
