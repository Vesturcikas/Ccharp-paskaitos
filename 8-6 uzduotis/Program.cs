using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti rėžių pradžią ir pabaigą. Patikrinkite, kad tai būtų validu (pradžia turi būti mažesnė nei pabaiga). 
            //Jei rėžiai tinkami, tuomet vykdyti for, kuris iš duotų skaičių išvestų visus nelyginius skaičius arba tuos, kurie dalinasi iš 8. 

            Console.WriteLine("Iveskite ciklo rezius (pradžia turi būti mažesnė nei pabaiga).");
            Console.Write("ciklo pradzia: ");
            var prad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ciklo pabaiga: ");
            var pab = Convert.ToInt32(Console.ReadLine());

            if (prad < pab)
            {
                for (int i = prad; i <= pab; i++)
                {
                    if (!(i % 2 == 0) || i % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                            }

            else
            {
                Console.WriteLine("KLAIDA!!! Blogai ivesti reziai.");
            }


        }
    }
}
