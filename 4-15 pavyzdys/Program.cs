using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_15_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite simboli: ");
            var simbolis = (char)Console.Read();
            Console.ReadLine(); // jeigu butu ivestas daugiau nei viena raide
            Console.WriteLine("ivestas simbolis: " + simbolis);
        }
    }
}
