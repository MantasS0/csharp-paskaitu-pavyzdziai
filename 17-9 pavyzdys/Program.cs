using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_9_pavyzdys
{
    class Program
    {
        public void MetodasVirsuje()
        {
            Console.WriteLine("metodas virsuje");
        }

        static void Main(string[] args)
        {
            var p = new Program();
            p.MetodasVirsuje();
        }
    }
}
