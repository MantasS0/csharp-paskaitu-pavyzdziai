using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_11_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai1 = new[] {4, 7, 5, 3, 6};
            var skaiciai2 = new[] {2, 5, 8, 9, 3};

            foreach (var skaicius in skaiciai1)
            {
                Console.WriteLine(skaicius);
            }

            Console.WriteLine();

            foreach (var skaicius in skaiciai2)
            {
                Console.WriteLine(skaicius);
            }
        }
    }
}
