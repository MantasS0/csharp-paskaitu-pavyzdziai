using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_8_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite pirma skaiciu: ");
            var pirmas = Convert.ToInt32(Console.ReadLine());

            Console.Write("iveskite veiksma (+ - * /): ");
            var veiksmas = Convert.ToChar(Console.Read());
            Console.ReadLine();

            Console.Write("iveskite antra skaiciu: ");
            var antras = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0} {1} {2} = ", pirmas, veiksmas, antras);
            switch (veiksmas)
            {
                case '+': Console.WriteLine(pirmas + antras); break;
                case '-': Console.WriteLine(pirmas - antras); break;
                case '*': Console.WriteLine(pirmas * antras); break;
                case '/': Console.WriteLine((double)pirmas / antras); break;
                default: Console.WriteLine("kazkas negerai"); break;
            }
        }
    }
}
