using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 0;

            while (skaicius < 10)
            {
                skaicius++;

                if (skaicius == 2 || skaicius == 4 || skaicius == 7)
                {
                    continue;
                }

                Console.WriteLine(skaicius);
            }
        }
    }
}
