using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_16_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kiek atsitiktiniu skaiciu sugeneruoti? ");
            var kiek = Convert.ToInt32(Console.ReadLine());
            var random = new Random();
            var skaiciai = new int[kiek];

            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = random.Next(100); // [0-100)
            }

            Console.Write("sugeneruoti skaiciai: ");

            foreach (var skaicius in skaiciai)
            {
                Console.Write(skaicius + " ");
            }

            Console.WriteLine();
        }
    }
}
