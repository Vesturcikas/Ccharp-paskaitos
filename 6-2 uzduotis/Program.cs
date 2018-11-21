using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti bet kokį teigiamą skaičių. 
            //Patikrinkite ar skaičius yra teigiamas (didesnis už nulį) ir ar yra lyginis (dalinasi iš 2).

            Console.Write("Iveskite bet koki skaiciu: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());

            if (sk1 >0 && sk1 %2==0)
            {
                Console.WriteLine("Ivestas skaicius {0} yra teigiamas ir lyginis", sk1);
            }
            else
            {
                Console.WriteLine("Ivestas skaicius {0} arba neteigiamas, arba nelyginis", sk1);
            }



        }
    }
}
