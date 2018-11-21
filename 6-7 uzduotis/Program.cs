using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite įvesti du skaičius. 
            //Patikrinkite, naudojant 4 atskiras if sąlygas: 
            //7.1. ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0; 
            //7.2. ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5; 
            //7.3. ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20; 
            //7.4. ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100;

            Console.WriteLine("Iveskite du skaicius.");
            Console.Write("sk1 = ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sk2 = ");
            var sk2 = Convert.ToInt32(Console.ReadLine());

            if (sk1>sk2 || sk1==0)
            {
                Console.WriteLine("1. Pirmas skaicius {0} yra didesnis uz antra arba lygus 0.", sk1);
            }
            
            if (sk1 < sk2 || sk2 == 5)
            {
                Console.WriteLine("2. Antras skaicius {0} yra didesnis uz pirma arba lygus 5.", sk2);
            }
            
            if (sk1 > sk2 && sk1 == 20)
            {
                Console.WriteLine("3. Pirmas skaicius {0} yra didesnis uz antra ir yra lygus 20.", sk1);
            }
            
            if (sk1 < sk2 && sk1 < 100)
            {
                Console.WriteLine("4. Antras skaicius {0} yra didesnis uz pirma ir mazesnis uz 100.", sk2);
            }

        }
    }
}
