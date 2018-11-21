using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite įvesti skaičių.Parašykite šias atskiras if sąlygas:
            //6.1.Jei skaičius lyginis, tuomet išveskite šį skaičių, bei jo penktą laipsnį. 
            //6.2.Jei skaičius nesidalina iš 4, tuomet liepkite įveskite antrąjį skaičių.Išveskite abiejų skaičių sumą ir sandaugą.

            Console.Write("Ivesite bet koki skaiciu: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());

            if (sk1%2==0)
            {
                Console.WriteLine("Ivestas skaicius: {0}. Ivesta skaiciu pakelus penktuoju laipsniu, gausime: {1}.", sk1, Math.Pow(sk1, 5));
            }

            if (sk1%4!=0)
            {
                Console.Write("Iveskite antra skaiciu: ");
                var sk2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skaiciu {0} ir {1} suma: {2}", sk1, sk2, sk1 + sk2);
                Console.WriteLine("Skaiciu {0} ir {1} sandauga: {2}", sk1, sk2, sk1 * sk2);
               
            }
        }
    }
}
