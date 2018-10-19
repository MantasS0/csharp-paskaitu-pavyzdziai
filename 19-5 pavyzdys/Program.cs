using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_5_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            Console.WriteLine("Pirmas kvietimas:");
            p.Tekstas();
            Console.WriteLine();

            Console.WriteLine("Antras kvietimas:");
            var tekstas = p.Tekstas();
            Console.WriteLine(tekstas);
            Console.WriteLine();

            Console.WriteLine("Trecias kvietimas:");
            Console.WriteLine(p.Tekstas());
            Console.WriteLine();
        }

        public string Tekstas()
        {
            return "Kazkoks apibreztas tekstas";
        }
    }
}
