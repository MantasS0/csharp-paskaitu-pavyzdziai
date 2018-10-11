using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite kelis pazymius (galima rasyti per kableli");
            var pazymys1 = Convert.ToDouble(Console.ReadLine());
            var pazymys2 = Convert.ToDouble(Console.ReadLine());
            var pazymys3 = Convert.ToDouble(Console.ReadLine());
            var pazymys4 = Convert.ToDouble(Console.ReadLine());
            var pazymys5 = Convert.ToDouble(Console.ReadLine());
            var vidurkis = (pazymys1 + pazymys2 + pazymys3 + pazymys4 + pazymys5) / 5;
            Console.WriteLine("ivestu pazymiu vidurkis: " + vidurkis);
        }
    }
}
