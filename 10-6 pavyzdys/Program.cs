using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var testi = true;

            do
            {
                Console.WriteLine("cia kazkokie norimi veiksmai");
                Console.WriteLine("testi? (t/n)");
                var pasirinkimas = Console.ReadLine();
                if (pasirinkimas != "t")
                {
                    testi = false;
                }
            } while (testi);
        }
    }
}
