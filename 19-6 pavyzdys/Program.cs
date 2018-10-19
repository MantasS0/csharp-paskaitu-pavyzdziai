using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_6_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            Console.WriteLine(p.Sakinys("Tomas", "Tomauskas", 25, "policininku"));
            Console.WriteLine(p.Sakinys("Giedre", "Giedraite", 21, "masaziste"));
        }

        public string Sakinys(string vardas, string pavarde, int amzius, string profesija)
        {
            return String.Format("{0} {1} ({2} m.) dirba {3}", vardas, pavarde, amzius, profesija);
        }
    }
}
