using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_6_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var petras = new Darbuotojas("Petras", "Petrauskas", 60, "pencininku", 400);
            var gytis = new Darbuotojas("Gytis", "Gytauskas", 25, "gaisrininku", 600);

            petras.Isvedimas();
            gytis.Isvedimas();
        }
    }
}
