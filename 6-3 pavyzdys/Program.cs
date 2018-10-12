using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var pradzia = 1;
            var pabaiga = 100;

            Console.Write("iveskite skaiciu: ");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius >= pradzia && skaicius <= pabaiga)
            {
                Console.WriteLine("skaicius patenka i rezius");
            }
            else
            {
                Console.WriteLine("skaicius nepatenka i rezius");
            }
        }
    }
}
