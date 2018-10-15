using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_9_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] {7, 8, 5, 2, 3, 9};

            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine(skaicius);
            }
        }
    }
}
