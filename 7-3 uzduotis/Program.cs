using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti tris skaičius. 
            //Tikrinkite pirmą skaičių: 
            //3.1. Ar pirmas skaičius lygus 1? Jei taip, išvesti visų trijų skaičių sumą. 
            //3.2. Ar pirmas skaičius lygus 2? Jei taip, išvesti antro ir trečio skaičių sandaugą. 
            //3.3. Ar pirmas skaičius lygus 3? Jei taip, išvesti pirmo skaičiaus kvadratą. 
            //3.4. Jei nei vienas variantas netinka, išveskite klaidos pranešimą.

            Console.WriteLine("Iveskite tris skaicius.");
            Console.Write("sk1 = ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sk2 = ");
            var sk2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sk3 = ");
            var sk3 = Convert.ToInt32(Console.ReadLine());

            switch (sk1)
            {
                case 1: Console.WriteLine("Ivestu skaiciu suma: {0}.", sk1 + sk2 + sk3); break;
                case 2: Console.WriteLine("Antro ir trecio skaiciu sandauga: {0}.", sk2 * sk3); break;
                case 3: Console.WriteLine("Pirmo skaiciaus kvadratas: {0}.", Math.Pow(sk1, 2)); break;
                default: Console.WriteLine("Klaida!!!"); break;
            }
        }
    }
}
