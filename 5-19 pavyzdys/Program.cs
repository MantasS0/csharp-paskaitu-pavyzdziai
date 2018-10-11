using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_19_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite gyvuna: ");
            var gyvunas = Console.ReadLine();

            if (gyvunas == "suo")
            {
                Console.WriteLine("ivestas gyvunas yra suo");
            }
            else if (gyvunas == "kate")
            {
                Console.WriteLine("ivestas gyvunas yra kate");
            }
            else if (gyvunas == "ziurkenas")
            {
                Console.WriteLine("ivestas gyvunas yra ziurkenas");
            }
            else if (gyvunas == "triusis")
            {
                Console.WriteLine("ivestas gyvunas yra triusis");
            }
        }
    }
}
