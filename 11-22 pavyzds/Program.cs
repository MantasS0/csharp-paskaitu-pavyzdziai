using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_22_pavyzds
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] {4, 3, 10, 7, 8, 9};
            var max = skaiciai[0];

            foreach (var sk in skaiciai)
            {
                if (sk > max)
                {
                    max = sk;
                }
            }

            Console.WriteLine("rastas didziausias: " + max);
        }
    }
}
