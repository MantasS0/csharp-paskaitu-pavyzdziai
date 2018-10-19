using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_11_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            
            var pirmas = new List<int>{5, 8, 7, 1, 2, 3};
            var antras = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9};

            p.Suma(pirmas);
            p.Suma(antras);
        }

        public void Isvedimas(List<int> skaiciai)
        {
            Console.Write("Sarase esantys skaiciai: ");

            foreach (var s in skaiciai)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine();
        }

        public void Suma(List<int> skaiciai)
        {
            var suma = 0;

            foreach (var s in skaiciai)
            {
                suma += s;
            }

            Isvedimas(skaiciai);
            Console.WriteLine("Sio masyvo skaiciu suma: " + suma + "\n");
        }
    }
}
