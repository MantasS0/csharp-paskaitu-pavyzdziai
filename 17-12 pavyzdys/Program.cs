using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_12_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Isvedimas();
        }

        public void Isvedimas()
        {
            Pirma();
            Antra();
        }

        public void Pirma()
        {
            Console.WriteLine("pirma");
        }

        public void Antra()
        {
            Console.WriteLine("antra");
        }
    }
}
