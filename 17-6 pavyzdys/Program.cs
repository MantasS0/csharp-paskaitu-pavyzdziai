using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_6_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Pirmas();
            p.Antras();
            p.Antras();
            p.Pirmas();
            p.Pirmas();
            p.Pirmas();
        }

        public void Pirmas()
        {
            Console.WriteLine("pirmas");
        }
        
        public void Antras()
        {
            Console.WriteLine("antras");
        }
    }
}
