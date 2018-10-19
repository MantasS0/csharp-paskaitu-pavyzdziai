using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_1_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Pasisveikinti("Ieva");
            p.Pasisveikinti("Gytis");
        }

        public void Pasisveikinti(string vardas)
        {
            Console.WriteLine("Labas, " + vardas);
        }
    }
}
