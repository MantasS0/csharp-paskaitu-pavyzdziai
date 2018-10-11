using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_12_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var mokausiProgramuoti = true;

            if (mokausiProgramuoti == true)
            {
                Console.WriteLine("mokausi programuoti! 1");
            }

            if (mokausiProgramuoti)
            {
                Console.WriteLine("mokausi programuoti! 2");
            }
        }
    }
}
