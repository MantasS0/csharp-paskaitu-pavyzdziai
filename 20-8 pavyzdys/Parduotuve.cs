using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_8_pavyzdys
{
    class Parduotuve
    {
        public string Pavadinimas { get; set; }
        public List<Preke> Prekes { get; set; }

        public Parduotuve(string pavadinimas, List<Preke> prekes)
        {
            Pavadinimas = pavadinimas;
            Prekes = prekes;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Parduotuve: " + Pavadinimas);
            Console.WriteLine("Turi sias prekes:");
            Console.WriteLine("+-----------------+-------+-------+------------+");
            Console.WriteLine("| Pavadinimas     | Savik | Kaina | Kodas      |");
            Console.WriteLine("+-----------------+-------+-------+------------+");

            foreach (var preke in Prekes)
            {
                preke.Isvedimas();
                Console.WriteLine("+-----------------+-------+-------+------------+");
            }

            Console.WriteLine();

            Console.WriteLine("Bendras prekiu pelnas: {0} eur", BendrasPelnas());
        }

        public double BendrasPelnas()
        {
            var pelnas = 0.0;

            foreach (var preke in Prekes)
            {
                pelnas += preke.Pelnas();
            }

            return pelnas;
        }
    }
}
