using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti teigiamą skaičių. 
            //Patikrinkite ar skaičius teigiamas, jei taip - išveskite pasveikinimą, o jei ne - aprėkite vartotoją.

            Console.Write("Ivesite bet koki teigiama skaiciu: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());


            if (sk1 > 0)
            {
                Console.WriteLine("SAUNUOLIS, moki skaityti :)");

            }

            else
            {
                Console.WriteLine("ASILE, prasiau ivesti teigiama skaiciu!!!");
            }

        }
    }
}
