using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] skaiciai = new int [3,4] {
                {0, 1, 2, 3} ,   /*  eile nr 0 */
                {4, 5, 6, 7} ,   /*  eile nr 1 */
                {8, 9, 10, 11}   /*  eile nr 2 */
            };

            for (var i = 0; i < 3; i++) {
            
                for (var j = 0; j < 4; j++) {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, skaiciai[i,j]);
                }
            }
        }
    }
}
