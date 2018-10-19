using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_3_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.SkaiciuotiSuma(5, 3);
            p.SkaiciuotiSuma(8, 7);
            p.SkaiciuotiSuma(1, 2);
            p.SkaiciuotiSuma(5, 8);
        }

        public void SkaiciuotiSuma(int a, int b)
        {
            var suma = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, suma);
        }
    }
}
