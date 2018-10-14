using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_13_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;

            for (int i = 1; i <= 10; i++)
            {
                suma += i;
            }

            Console.WriteLine("skaiciu [1-10] suma: " + suma);
        }
    }
}
