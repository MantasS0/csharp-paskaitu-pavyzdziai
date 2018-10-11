using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_20_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite skaiciu: ");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius >= 0)
            {
                Console.WriteLine("skaicius yra teigiamas arba lygus 0");
            }
            else
            {
                Console.WriteLine("skaicius yra neigiamas");
            }
        }
    }
}
