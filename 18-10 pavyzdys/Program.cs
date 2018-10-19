using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_10_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            var skaiciai1 = new List<int> {5, 8, 9, 3, 5, 6, 5};
            var skaiciai2  = new List<int>{5, 8, 1, 3, 6, 4, 8};

            p.Suma(skaiciai1);
            p.Suma(skaiciai2);
        }

        public void Suma(List<int> sarasas)
        {
            var suma = 0;

            foreach (var elementas in sarasas)
            {
                suma += elementas;
            }

            Console.WriteLine("suma: " + suma);
        }
    }
}
