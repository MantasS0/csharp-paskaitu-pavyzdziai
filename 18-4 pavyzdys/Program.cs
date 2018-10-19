using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_4_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            p.Sudetis(4, 7, 3);
            p.Sudetis(2, 4, 3);
            p.Sudetis(8, 7, 6);
        }

        public void Sudetis(int a, int b, int c)
        {
            var suma = a + b + c;
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, suma);
        }
    }
}
