using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti tris skaičius. Raskite kuris iš šių skaičių yra didžiausias.

            Console.WriteLine("Iveskite tris skaicius.");
            Console.Write("sk1 = ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sk2 = ");
            var sk2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sk3 = ");
            var sk3 = Convert.ToInt32(Console.ReadLine());

            if (sk1>sk2 && sk2>sk3)
            {
                Console.WriteLine("Skaicius {0} yra didziausias is [{0}, {1}, {2}].", sk1, sk2, sk3);
            }
            else if (sk2>sk1 && sk1>sk3)
            {
                Console.WriteLine("Skaicius {1} yra didziausias is [{0}, {1}, {2}].", sk1, sk2, sk3);
            }
            else //if (sk3>sk1 && sk3>sk2)
            {
                Console.WriteLine("Skaicius {2} yra didziausias is [{0}, {1}, {2}].", sk1, sk2, sk3);
            }
        }
    }
}
