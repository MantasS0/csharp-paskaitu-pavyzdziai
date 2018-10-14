using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardas = "Greta";

            if (vardas == "Paulius")
            {
                Console.WriteLine("Labas, Pauliau");
            }
            else if (vardas == "Greta")
            {
                Console.WriteLine("Labas, Greta");
            }

            switch (vardas)
            {
                case "Paulius":
                    Console.WriteLine("Labas, Pauliau");
                    break;
                case "Greta":
                    Console.WriteLine("Labas, Greta");
                    break;
            }
        }
    }
}
