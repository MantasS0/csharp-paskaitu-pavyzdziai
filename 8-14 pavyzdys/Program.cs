using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_14_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
            }

            Console.WriteLine("lyginiu skaiciu kurie patenka i rezius [1-10] suma: " + suma);
        }
    }
}
