using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_7_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Skaiciavimai(4, 7);
            p.Skaiciavimai(5, 3);
        }

        public void Skaiciavimai(int a, int b)
        {
            Sudetis(a, b);
            Atimtis(a, b);
            Console.WriteLine();
        }

        public void Sudetis(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        public void Atimtis(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
    }
}
