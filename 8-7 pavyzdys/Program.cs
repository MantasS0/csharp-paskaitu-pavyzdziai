using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_7_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite reziu pradzia: ");
            var pradzia = Convert.ToInt32(Console.ReadLine());

            Console.Write("iveskite reziu pabaiga: ");
            var pabaiga = Convert.ToInt32(Console.ReadLine());

            Console.Write("skaiciai patenkantys i rezius [{0}-{1}]: ", pradzia, pabaiga);

            for (int i = pradzia; i <= pabaiga; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
