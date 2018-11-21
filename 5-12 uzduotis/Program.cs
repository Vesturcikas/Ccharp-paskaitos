using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti du skaičius. 
            //Patikrinkite ar pirmas skaičius didesnis už antrąjį, jei taip - išveskite, kad pirmas skaičius didesnis už antrąjį, 
            //o jei ne - išveskite, kad įvyko klaida.

            Console.WriteLine("Iveskite du skaicius.");
            Console.Write("sk1 = ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sk2 = ");
            var sk2 = Convert.ToInt32(Console.ReadLine());

            if (sk1 > sk2)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz {1}.", sk1, sk2);
            }
            else
            {
                Console.WriteLine("Ivyko klaida!!!");
            }
        }
    }
}
