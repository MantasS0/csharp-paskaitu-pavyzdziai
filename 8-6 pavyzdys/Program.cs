using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_6_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite kiek skaiciu parodyti: ");
            var kiek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("skaiciai: ");

            for (int i = 1; i <= kiek; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
