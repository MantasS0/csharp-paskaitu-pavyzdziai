using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_14_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("iveskite skaiciu: ");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("ivesti skaiciai:");

            foreach (var skaicius in skaiciai)
            {
                Console.Write(skaicius + " ");
            }

            Console.WriteLine();
        }
    }
}
