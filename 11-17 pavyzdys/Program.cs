using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_17_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var skaiciai = new int[100];

            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = rand.Next(1, 100); // [1-100)
            }

            Console.WriteLine("sugeneruoti skaiciai:");

            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.Write(skaiciai[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
