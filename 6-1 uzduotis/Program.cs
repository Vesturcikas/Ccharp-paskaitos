using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Susikurkite du kintamuosius rėžių pradžiai ir pabaigai saugoti. 
            //Liepkite vartotojui įvesti skaičių. Patikrinkite ar skaičius patenka į nurodytus rėžius.

            var prad = 45;
            var pab = 152;

            Console.Write("Iveskite bet koki teigiama skaiciu: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());

            if (sk1>=prad && sk1<=pab)
            {
                Console.WriteLine("Ivestas skaicius {0} patenka tarp {1} ir {2}", sk1, prad, pab);
            }
            else
            {
                Console.WriteLine("Ivestas skaicius {0} nepatenka tarp {1} ir {2}", sk1, prad, pab);
            }
        }
    }
}
