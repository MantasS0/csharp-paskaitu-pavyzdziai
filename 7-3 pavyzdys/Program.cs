using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 2;

            if (skaicius == 1)
            {
                Console.WriteLine("skaicius lygus 1");
            }
            else
            {
                Console.WriteLine("skaicius nerastas");
            }

            switch (skaicius)
            {
                case 1:
                    Console.WriteLine("skaicius lygus 1");
                    break;
                default:
                    Console.WriteLine("skaicius nerastas");
                    break;
            }
        }
    }
}
