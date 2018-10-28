using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bahahh
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine(p.Suma(4, 7, 8, 2, 3));
            Console.WriteLine(p.Suma(7, 4, 5, 3));
            Console.WriteLine(p.visi("hsddg", "shbgh"));
            Console.WriteLine(p.visi("hsgh", "hsghd", "sg"));
        }

        public int Suma(params int[] numbers)
        {
            return numbers.Sum();
        }

        public string visi(params string[] bahahahahahahaha)
        {
            return "aaa";
        }
    }
}
