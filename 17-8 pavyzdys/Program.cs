using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_8_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            var pirmas = 5;
            var antras = 9;

            p.Sudeti();
        }

        public void Sudeti()
        {
            Console.WriteLine(pirmas + antras);
        }
    }
}
