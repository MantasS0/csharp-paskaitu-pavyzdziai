using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_6_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                p.Sudetis(rand.Next(100), rand.Next(100));
            }
        }

        public void Sudetis(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
    }
}
