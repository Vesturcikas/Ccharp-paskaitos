using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti teigiamą skaičių. 
            //Patikrinkite ar tas skaičius dalinasi iš 7, jei taip - išveskite norimą tekstą, o jei ne - išveskite, kad toks skaičius netinka. 

            Console.Write("Ivesite bet koki skaiciu: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());

            if (sk1 % 7 == 0)
            {
                Console.WriteLine("Ivestas skaicius: {0} dalinasi is 7. ", sk1);
            }
            else
            {
                Console.WriteLine("Ivestas skaicius: {0} nesidalina is 7. Liekana: {1}. ", sk1, sk1%7);
            }


        }
    }
}
