using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti amžių. Patikrinkite ar amžius yra didesnis arba lygus 18-ai, jei taip - išveskite “jūs galite balsuoti”.

            Console.Write("Iveskite savo amziu: ");

            var amz = Convert.ToInt32(Console.ReadLine());

            if (amz >18)
            {
                Console.WriteLine("Jus galite balsuoti.");
            }


        }
    }
}
