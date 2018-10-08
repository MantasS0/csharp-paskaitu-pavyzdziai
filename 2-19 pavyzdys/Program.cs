using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_19_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 7;
            var b = 5;

            Console.WriteLine("{0} {1}", a, b);
            Console.WriteLine("{0} {0} {1} {0}", a, b);
            Console.WriteLine("{0} {0} {0} {0}", a, b);
            Console.WriteLine("{1} {1} {1} {1}", a, b);
            Console.WriteLine("{1} {0} {0} {1}", a, b);
        }
    }
}
