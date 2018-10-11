using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_17
{
    class Program
    {
        static void Main(string[] args)
        {
            var pinigai = 10;
            var vip = true;

            if (vip)
            {
                Console.WriteLine("vip iejimas");
            }
            else if (pinigai > 5)
            {
                Console.WriteLine("galite nusipirkti bilieta");
            }
        }
    }
}
