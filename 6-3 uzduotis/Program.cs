using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti bet kokį skaičių. 
            //Patikrinkite ar skaičius dalinasi iš 2 arba 5 arba 7. 

            Console.Write("Iveskite bet koki skaiciu: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());

            if (sk1 % 2 == 0 || sk1 % 5 == 0 || sk1 % 7 == 0)
            {
                Console.WriteLine("Ivestas skaicius {0} tinka uzdaviniui.", sk1);
            }
            else
            {
                Console.WriteLine("Ivestas skaicius {0} netinka uzdaviniui", sk1);
            }



        }
    }
}
