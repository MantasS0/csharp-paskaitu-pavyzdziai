using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_8_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Lentele(3, 3);
            p.Lentele(2, 5);
            p.Lentele(4, 5);
        }

        public void Lentele(int eilutes, int stulpeliai)
        {
            Console.WriteLine("Daugybos lentele {0}x{1}", eilutes, stulpeliai);

            for (int i = 1; i <= eilutes; i++)
            {
                for (int j = 1; j <= stulpeliai; j++)
                {
                    Console.Write("{0,-4}", i * j);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
