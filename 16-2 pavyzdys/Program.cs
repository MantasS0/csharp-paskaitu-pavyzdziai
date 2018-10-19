using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_2_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Metodas();
            Metodas(); // jei toje pacioje klaseje
        }

        private static void Metodas()
        {
            Console.WriteLine("metodo tekstas");
        }
    }
}
