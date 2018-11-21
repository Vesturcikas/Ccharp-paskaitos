using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti egzamino pažymį [0-10]. 
            //Naudojant else if dalis patikrinkite šias sąlygas ir išveskite atitinkamą tekstą: 
            //8.1. Jei pažymys yra lygus 10 išvesti “puiku”. 
            //8.2. Jei pažymys yra lygus 9 išvesti “labai gerai”. 
            //8.3. Jei pažymys yra lygus arba didesnis nei 7 išvesti “gerai”. 
            //8.4. Jei pažymys yra lygus arba didesnis nei 5 išvesti “patenkinamai”. 
            //8.5. Jei pažymys mažesnis nei 5 išvesti “egzaminas neišlaikytas”.

            Console.Write("Ivesite savo pazymi (nuo 0 iki 10): ");
            var sk1 = Convert.ToInt32(Console.ReadLine());

            if (sk1 == 10)
            {
                Console.WriteLine("Puiku.");
            }

            else if (sk1 == 9)
            {
                Console.WriteLine("Labai gerai.");
            }

            else if (sk1 >= 7)
            {
                Console.WriteLine("Gerai.");
            }

            else if (sk1 >= 5)
            {
                Console.WriteLine("Patenkinamai.");
            }

            else if (sk1 < 5)
            {
                Console.WriteLine("Neislaikyta.");
            }

        }
    }
}
