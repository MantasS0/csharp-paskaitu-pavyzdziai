using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_9_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new List<int> {7, 4, 2, 3, 5, 8, 9};

            for (int i = 0; i < skaiciai.Count; i++)
            {
                Console.Write(skaiciai[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
