using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurkite ir iškvieskite metodą, kuris į ekraną išvestų trumpą eilėraštį.

            var eil = new Program();

            eil.eilerastis();
                        
            Console.WriteLine("Pakartosime:");
            Console.WriteLine();
            eil.eilerastis();
        }

        public void eilerastis()
        {
            Console.WriteLine("Eglute skarota,");
            Console.WriteLine("Eglute zalia.");
            Console.WriteLine("Meskute gauruota");
            Console.WriteLine("Ja lanko miske.");
            Console.WriteLine();
        }
    }
}
