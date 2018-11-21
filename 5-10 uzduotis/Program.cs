using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti skaičių. Patikrinkite ar skaičius lyginis, jei taip - išveskite, kad skaičius lyginis, o jei ne - kad nelyginis.

            Console.Write("Ivesite bet koki skaiciu: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());

            if (sk1 % 2 == 0)
            {
                Console.WriteLine("Ivestas skaicius: {0} yra lyginis. ", sk1);
            }
            else
            {
                Console.WriteLine("Ivestas skaicius: {0} yra nelyginis. ", sk1);
            }

        }
    }
}
