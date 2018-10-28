using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_11_2018_10_23_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var knygynas = new Knygynas("Pegasas", "Akropolis", new List<Knyga>
            {
                new Knyga("Haris poteris", "Rawling??", 500, "vaikiska", 12.99, 30),
                new Knyga("Pavadinimabsj", "Autorusgh", 315, "siaubo", 14.99, 50),
                new Knyga("Ytsyf", "Hhgsvgfh", 541, "fantastine", 19.99, 25),
                new Knyga("HJJH", "Hhgfsd", 201, "romanas", 9.99, 20)
            });

            knygynas.Isvedimas();
        }
    }
}
