using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti tris skaičius. 
            //Parašykite šiuos patikrinimus, naudojant else if dalis: 
            //7.1. Ar pirmas skaičius didesnis už antrą? 
            //7.2. Ar trečias skaičius didesnis už pirmą? 
            //7.3. Ar pirmi du skaičiai yra lygūs? 
            //7.4. Ar paskutiniai du skaičiai yra lygūs? 

            Console.WriteLine("Iveskite tris skaicius.");
            Console.Write("sk1 = ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sk2 = ");
            var sk2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sk3 = ");
            var sk3 = Convert.ToInt32(Console.ReadLine());

            if (sk1>sk2)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz {1}.", sk1, sk2);
            }

            else if (sk3>sk1)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz {1}.", sk3, sk1);
            }

            else if (sk1 == sk2)
            {
                Console.WriteLine("Skaiciai {0} ir {1} yra lygus.", sk1, sk2);
            }

            else if (sk2 == sk3)
            {
                Console.WriteLine("Skaiciai {0} ir {1} yra lygus.", sk2, sk3);
            }


        }
    }
}
