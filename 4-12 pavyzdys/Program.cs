using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ar turite aukstojo mokslo diploma? (true/false)");
            var arDiplomas = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("diplomas: " + arDiplomas);
        }
    }
}
