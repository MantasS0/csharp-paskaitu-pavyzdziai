using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_18_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var pirmas = "dramblys";
            var antras = "dviratis";
            var trecias = "svarstykles";
            var ketvirtas = "laikrodis";
            var penktas = "tesla";

            Console.WriteLine("{0}{1}{2}{3}{4}", pirmas, antras, trecias, ketvirtas, penktas);
            Console.WriteLine("{0} {1} {2} {3} {4}", pirmas, antras, trecias, ketvirtas, penktas);
            Console.WriteLine("{0}/{1}/{2}/{3}/{4}", pirmas, antras, trecias, ketvirtas, penktas);
            Console.WriteLine();

            Console.Write("{0} {1} {2} ", pirmas, antras, trecias);
            Console.WriteLine("{0} {1}", ketvirtas, penktas);
            Console.WriteLine();

            Console.WriteLine("{0} {1} {2} {3} {4}", pirmas, antras,
                trecias, ketvirtas, penktas);
        }
    }
}
