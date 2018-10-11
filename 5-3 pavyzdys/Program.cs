using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 5;

            if (skaicius > 0)
            {
                Console.WriteLine("skaicius yra teigiamas");
            }

            if (skaicius < 0)
            {
                Console.WriteLine("skaicius yra neigiamas");
            }
        }
    }
}
