using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti skaičių. 
            //Patikrinkite: 
            //13.1. Ar skaičius dalinasi iš 2? 
            //13.2. Ar skaičius dalinasi iš 3? 
            //13.3. Ar skaičius dalinasi iš 4? 
            //13.4. Ar skaičius dalinasi iš 5? 
            //13.5. Ar skaičius dalinasi iš 7? 
            //13.6. Jeigu skaičius iš nieko nesidalina, išvesti klaidos pranešimą. 

            Console.Write("Ivesite bet koki skaiciu: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());

            if (sk1 % 2 == 0)
            {
                Console.WriteLine("Ivestas skaicius: {0} dalinasi is 2. ", sk1);
            }
            else if (sk1%3==0)
            {
                Console.WriteLine("Ivestas skaicius: {0} dalinasi is 3. ", sk1);
            }
            else if (sk1 % 4 == 0)
            {
                Console.WriteLine("Ivestas skaicius: {0} dalinasi is 4. ", sk1);
            }
            else if (sk1 %5 == 0)
            {
                Console.WriteLine("Ivestas skaicius: {0} dalinasi is 5. ", sk1);
            }
            else if (sk1 % 7 == 0)
            {
                Console.WriteLine("Ivestas skaicius: {0} dalinasi is 7. ", sk1);
            }
            else
            {
                Console.WriteLine("Skaicius {0} nesidalina is 2, 3, 4, 5 ir 7.", sk1);
            }



        }
    }
}
