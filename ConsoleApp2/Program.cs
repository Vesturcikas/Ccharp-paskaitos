using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti rėžių pradžią ir pabaigą. 
            //Patikrinkite, kad tai būtų validu (pradžia turi būti mažesnė nei pabaiga). 
            //Jei rėžiai tinkami, tuomet vykdyti for, kuris atskirose eilutėse išvestų kiekvieną skaičių iš tų rėžių, bei atskiriant tarpu - tų skaičių kvadratus.

            Console.WriteLine("Iveskite ciklo rezius (pradžia turi būti mažesnė nei pabaiga).");
            Console.Write("ciklo pradzia: ");
                var prad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ciklo pabaiga: ");
            var pab = Convert.ToInt32(Console.ReadLine());

            if (prad<pab)
            {
                for (int i = prad; i <= pab; i++)
                {
                    Console.WriteLine(i + " " + Math.Pow(i, 2));
                }

            }

            else
            {
                Console.WriteLine("KLAIDA!!! Blogai ivesti reziai.");
            }

        }
    }
}
