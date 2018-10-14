using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var veiksmas = "t";

            while (veiksmas == "t")
            {
                Console.WriteLine("yey! as cikle");
                Console.WriteLine("ar norite testi? (t/n)");
                veiksmas = Console.ReadLine();
            }
        }
    }
}
