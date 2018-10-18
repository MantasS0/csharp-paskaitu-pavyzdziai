using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_8_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new List<int> {4, 7, 8, 5, 3, 6};

            skaiciai.Add(7);
            skaiciai.Add(2);
            skaiciai.Add(9);
            skaiciai.Add(10);
            skaiciai.Add(15);

            foreach (var skaicius in skaiciai)
            {
                Console.Write(skaicius + " ");
            }

            Console.WriteLine();
        }
    }
}
