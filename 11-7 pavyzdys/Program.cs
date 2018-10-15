using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_7_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] {1, 4, 8, 5, 2, 3};

            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.WriteLine(skaiciai[i]);
            }
        }
    }
}
