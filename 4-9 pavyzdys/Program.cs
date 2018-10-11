using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_9_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite savo ugi (m.)");
            var ugis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("jusu ugis: {0} m.", ugis);
        }
    }
}
