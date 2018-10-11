using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_13_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite norima simboli: ");
            var simbolis = Convert.ToChar(Console.Read());
            Console.ReadLine(); // jeigu butu ivestas daugiau nei vienas simbolis
            Console.WriteLine("ivestas simbolis: " + simbolis);
        }
    }
}
