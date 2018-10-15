using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_8_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] {4, 7, 8, 3, 2, 1};

            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.Write(skaiciai[i] + " ");
            }
        }
    }
}
