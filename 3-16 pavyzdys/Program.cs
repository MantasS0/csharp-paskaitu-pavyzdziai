using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_16_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 9;
            var saknis = Math.Sqrt(skaicius);
            Console.WriteLine("saknis: " + saknis);

            Console.WriteLine("skaiciaus 4 saknis: " + Math.Sqrt(4));
        }
    }
}
