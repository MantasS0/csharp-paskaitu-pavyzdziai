using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_12_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            Console.WriteLine("a = " + a + "\n");

            var b = a++;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b + "\n");
        }
    }
}
