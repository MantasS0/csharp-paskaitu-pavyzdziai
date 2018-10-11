using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_13_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius > 0)
            {
                Console.WriteLine("ivestas skaicius yra teigiamas");
            }

            if (skaicius < 0)
            {
                Console.WriteLine("ivestas skaicius yra neigiamas");
            }
        }
    }
}
