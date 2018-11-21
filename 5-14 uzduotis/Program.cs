using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_14_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti du skaičius. Patikrinkite: 
            //14.1. Ar pirmas skaičius didesnis už antrą? 
            //14.2. Ar antras skaičius didesnis už pirmą? 
            //14.3. Jeigu nei vienas skaičius nėra didesnis už kitą - tai skaičiai yra lygūs.

            Console.WriteLine("Iveskite du skaicius.");
            Console.Write("sk1 = ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sk2 = ");
            var sk2 = Convert.ToInt32(Console.ReadLine());

            if (sk1 > sk2)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz {1}.", sk1, sk2);
            }
            else if (sk2 > sk1)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz {1}.", sk2, sk1);
            }
            else
            {
                Console.WriteLine("Skaiciai {0} ir {1} yra lygus.", sk1, sk2);
            }
        }
    }
}
