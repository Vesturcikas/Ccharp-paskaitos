using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti bet kokį teigiamą skaičių. 
            //Parašykite šias atskiras if sąlygas: 
            //5.1. patikrinti ar skaičius neigiamas, jei taip - aprėkti vartotoją :) 
            //5.2. patikrinti ar skaičius teigiamas, jei taip - pasveikinti vartotoją; 
            //5.3. patikrinti ar skaičius lyginis; 
            //5.4. patikrinti ar skaičius dalinasi iš 4; 
            //5.5. patikrinti ar skaičius yra didesnis nei 10.

            Console.Write("Ivesite bet koki teigiama skaiciu: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());

            if (sk1<0)
            {
                Console.WriteLine("ASILE, prasiau ivesti teigiama skaiciu!!!");
            }

            if (sk1 > 0)
            {
                Console.WriteLine("SAUNUOLIS, moki skaityti :)");
            }

            if (sk1%2 ==0)
            {
                Console.WriteLine("Skaicius {0} yra lyginis.",sk1);

            }

            if (sk1 % 4 == 0)
            {
                Console.WriteLine("Skaicius {0} dalinasi is keturiu", sk1);

            }

            if (sk1 >10)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz 10.", sk1);

            }

        }
    }
}
