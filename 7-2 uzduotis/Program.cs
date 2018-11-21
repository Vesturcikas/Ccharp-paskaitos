using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti turimą rolę. 
            //Tikrinkite: 
            //2.1. Ar rolė yra “vartotojas”? 
            //2.2. Ar rolė yra “moderatorius”? 
            //2.3. Ar rolė yra “administratorius”? 
            //2.4. Jei nei vienas pasirinkimas netinka, išveskite klaidos pranešimą. 

            Console.WriteLine("Pasirinkite forumo role: vartotojas/moderatorius/administratorius.");
            Console.Write("Jusu pasirinkimas: ");

            var pasir = Console.ReadLine();

            switch (pasir)
            {
                case "vartotojas": Console.WriteLine("Aciu, Jus pasirinkote vartotojo role."); break;
                case "moderatorius": Console.WriteLine("Aciu, Jus pasirinkote moderatoriaus role."); break;
                case "administratorius": Console.WriteLine("Aciu, Jus pasirinkote administratoriaus role."); break;
                default: Console.WriteLine("Klaida!!! "); break;
            }
        }
    }
}
