using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti bet kokį skaičių. Atlikite šiuos patikrinimus ir veiksmus: 
            //4.1. Jei skaičius dalinasi iš 5, tuomet išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5. 
            //4.2. Jei skaičius lyginis, tuomet išveskite šį skaičių, jo kvadratą ir jį padalintą iš 2. 
            //4.3. Jei skaičius nesidalina iš 7, tuomet susikurkite antrąjį kintamąjį, išveskite šių dviejų skaičių sumą, skirtumą, sandaugą, dalmenį.

            Console.Write("Ivesite bet koki skaiciu: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());

            if (sk1%5 ==0)
            {
                Console.WriteLine("Skaiciaus {0} daugybos lentele: ", sk1);
                Console.WriteLine("{0} * 1 = {1};", sk1, sk1 * 1);
                Console.WriteLine("{0} * 2 = {1};", sk1, sk1 * 2);
                Console.WriteLine("{0} * 3 = {1};", sk1, sk1 * 3);
                Console.WriteLine("{0} * 4 = {1};", sk1, sk1 * 4);
                Console.WriteLine("{0} * 5 = {1};", sk1, sk1 * 5);
            }

            if (sk1%2 ==0)
            {
                Console.WriteLine("Skaiciaus {0} kvadratas: {1}, o padalinus is 2 lygu: {2}.", sk1, Math.Pow(sk1, 2), sk1 / 2);
            }

            if (sk1%7 !=0)
            {
                Console.Write("Iveskite antra skaiciu: ");
                var sk2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skaiciu {0} ir {1} suma: {2}", sk1, sk2, sk1 + sk2);
                Console.WriteLine("Skaiciu {0} ir {1} skirtumas: {2}", sk1, sk2, sk1 - sk2);
                Console.WriteLine("Skaiciu {0} ir {1} sandauga: {2}", sk1, sk2, sk1 * sk2);
                Console.WriteLine("Skaiciu {0} ir {1} dalmuo: {2}", sk1, sk2, sk1 / sk2);

            }

        }
    }
}
