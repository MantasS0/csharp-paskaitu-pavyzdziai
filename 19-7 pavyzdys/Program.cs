using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_7_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            var skaiciai = new List<int>{4, 7, 2, 3, 5, 8, 9, 5};

            var suma = p.Suma(skaiciai);
            Console.WriteLine("skaiciu suma: " + suma);

            Console.WriteLine("skaiciu suma: " + p.Suma(skaiciai));
        }

        public int Suma(List<int> skaiciai)
        {
            var suma = 0;

            foreach (var i in skaiciai)
            {
                suma += i;
            }

            return suma;
        }
    }
}
