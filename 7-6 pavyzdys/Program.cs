using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_6_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("uzsakymo busena: ");
            var uzsakymas = Console.ReadLine();

            switch (uzsakymas)
            {
                case "sukurtas":
                    Console.WriteLine("uzsakymas buvo sukurtas, greitu metu bus issiustas");
                    break;
                case "patvirtintas":
                    Console.WriteLine("uzsakymo vykdymas patvirtintas, siuntini tuoj perims kurjeris");
                    break;
                case "vykdomas":
                    Console.WriteLine("preke siuo metu keliauja");
                    break;
                case "paruostas":
                    Console.WriteLine("preke jau galite atsiimti salone");
                    break;
                case "baigtas":
                    Console.WriteLine("preke atsiimta");
                    break;
                default:
                    Console.WriteLine("kazkas negerai");
                    break;
            }
        }
    }
}
