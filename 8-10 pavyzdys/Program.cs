using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; true; i++)
            {
                Console.WriteLine(i);
                if (i >= 5)
                {
                    break; // nutraukia artimiausia cikla
                }
            }
        }
    }
}
