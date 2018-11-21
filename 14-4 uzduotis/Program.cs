using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sukurkite iš iškvieskite metodą, kuris paprašytų vartotojo įvesti savo vardą. 
            //Po įvedimo, metodas turi pasisveikinti su vartotoju. 

            var p = new Program();

            p.pasisveikinimas();

        }

        public void pasisveikinimas()
        {
            Console.Write("Iveskite savo varda: ");
            var vardas = Console.ReadLine();
            Console.WriteLine("Labas " + vardas);
        }


    }
}
