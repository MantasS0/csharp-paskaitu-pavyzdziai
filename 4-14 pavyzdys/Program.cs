using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_14_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite simboli: ");
            var simbolis = Console.Read();
            Console.ReadLine(); // jeigu butu ivesta daugiau raidziu

            Console.WriteLine("ivesto simbolio skaitmenine reiksme: " + simbolis);
            Console.WriteLine("sukonvertuotas simbolis: " + (char)simbolis);
            Console.WriteLine("sukonvertuotas simbolis: " + Convert.ToChar(simbolis));
        }
    }
}
