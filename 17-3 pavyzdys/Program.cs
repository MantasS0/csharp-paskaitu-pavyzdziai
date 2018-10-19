using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_3_pavyzdys
{
    class Program
    {
         static void Main(string[] args)
        {
            var p = new Program();

            for (int i = 0; i < 5; i++)
            {
                p.Labas();
            }
        }

        public void Labas()
        {
            Console.WriteLine("labas ir tau");
        }
    }
}
