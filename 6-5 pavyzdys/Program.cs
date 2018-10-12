using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_5_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var kaina = 0;
            var nemokama = true;

            if (kaina > 0 || nemokama == true)
            {
                Console.WriteLine("preke parduodama");
            }

            if (kaina > 0 || nemokama)
            {
                Console.WriteLine("preke parduodama");
            }
        }
    }
}
