using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 4;

            if (skaicius > 0)
            {
                Console.WriteLine("skaicius yra teigiamas");
            }

            if (skaicius == 0)
            {
                Console.WriteLine("skaicius yra lygus nuliui");
            }
        }
    }
}
