using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 1;
            var suma = 0;

            do
            {
                suma += skaicius;
                skaicius++;
            } while (skaicius <= 100);

            Console.WriteLine("skaiciu [1-100] suma: " + suma);
        }
    }
}
