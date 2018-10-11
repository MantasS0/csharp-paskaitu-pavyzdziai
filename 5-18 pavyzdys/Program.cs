using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_18_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite savo amziu: ");
            var amzius = Convert.ToInt32(Console.ReadLine());

            if (amzius >= 18)
            {
                Console.WriteLine("esate pilnametis");
            }
            else if (amzius >= 16)
            {
                Console.WriteLine("jusu amzius yra 16 arba 17");
            }
            else if (amzius < 16)
            {
                Console.WriteLine("jums yra iki 16 metu");
            }
        }
    }
}
