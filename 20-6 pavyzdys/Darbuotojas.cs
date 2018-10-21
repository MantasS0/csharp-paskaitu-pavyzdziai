using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_6_pavyzdys
{
    class Darbuotojas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int Amzius { get; set; }
        public string Profesija { get; set; }
        public int Alga { get; set; }

        public Darbuotojas(string vardas, string pavarde, int amzius, string profesija, int alga)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Profesija = profesija;
            Alga = alga;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Darbuotojas {0} {1} kurio amzius {2} metu dirba {3}, jo alga siekia {4} eur/men",
                Vardas, Pavarde, Amzius, Profesija, Alga);
        }
    }
}
