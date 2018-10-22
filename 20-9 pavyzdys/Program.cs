using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_9_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pilnas kelias iki csv failo:");
            var kelias = Console.ReadLine();

            var automobiliai = new Automobiliai(kelias);
            automobiliai.Isvedimas();
        }
    }
}
