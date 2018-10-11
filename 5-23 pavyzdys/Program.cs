using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_23_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = -3;

            if (skaicius > 0)
            {
                Console.WriteLine("skaicius yra teigiamas");
            }
            else if (skaicius < 0)
            {
                Console.WriteLine("skaicius yra neigiamas");
            }
            else
            {
                Console.WriteLine("skaicius yra lygus 0");
            }
        }
    }
}
