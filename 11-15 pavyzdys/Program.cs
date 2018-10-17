using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_15_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kiek skaiciu norite suvesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());
            var skaiciai = new int[kiek];

            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.Write("iveskite {0}-aji skaiciu: ", i+1);
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("---------------");
            Console.WriteLine("jusu ivesti skaiciai: ");

            foreach (var skaicius in skaiciai)
            {
                Console.Write(skaicius + " ");
            }

            Console.WriteLine();
        }
    }
}
