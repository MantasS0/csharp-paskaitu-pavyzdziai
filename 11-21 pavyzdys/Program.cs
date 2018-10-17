using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_21_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] {5, 8, 6, 8, 7, 2, 3, 1, 5};
            var min = skaiciai[0];

            foreach (var sk in skaiciai)
            {
                if (sk < min)
                {
                    min = sk;
                }
            }

            Console.WriteLine("rastas maziausias: " + min);
        }
    }
}
