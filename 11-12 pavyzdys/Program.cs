using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _11_12_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] {8, 5, 7, 9, 6};
            var simboliai = new[] {'a', 't', 'c'};

            Console.WriteLine("skaiciu masyvo dydis: " + skaiciai.Length);
            Console.WriteLine("simboliu masyvo dydis: " + simboliai.Length);
            Console.WriteLine();

            Console.WriteLine("pirmas skaicius: " + skaiciai.First());
            Console.WriteLine("paskutinis skaicius: " + skaiciai.Last());
            Console.WriteLine();

            Console.WriteLine("pirmas ir paskutinis simboliai: {0} {1}",
                simboliai.First(), simboliai.Last());
            Console.WriteLine();

            Console.WriteLine("paskutinis skaicius: " + skaiciai[skaiciai.Length - 1]);
            Console.WriteLine("paskutinis simbolis: " + simboliai[simboliai.Length - 1]);
        }
    }
}
