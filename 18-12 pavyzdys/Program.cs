using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_12_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            var zodziai1 = new List<string>{"pirmas", "antras", "trecias", "ketvirtas"};
            var zodziai2 = new List<string>{"penktas", "sestas", "septintas"};

            p.Isvedimas("Pirmas zodziu sarasas", zodziai1);
            p.Isvedimas("Antras zodziu sarasas", zodziai2);
        }

        public void Isvedimas(string komentaras, List<string> zodziai)
        {
            Console.WriteLine(komentaras);

            foreach (var z in zodziai)
            {
                Console.WriteLine("- " + z);
            }

            Console.WriteLine();
        }
    }
}
