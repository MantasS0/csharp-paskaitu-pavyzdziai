using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_11_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite masinos gamybos metus: ");
            var gamybosMetai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masinai yra " + (2018 - gamybosMetai) + " metu");
        }
    }
}
