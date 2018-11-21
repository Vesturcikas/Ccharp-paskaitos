using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti tris skaičius. Parašykite šias atskiras if sąlygas: 
            //1.1. Ar pirmas ir antras skaičiai yra lygūs? 
            //1.2. Ar antras ir trečias skaičiai yra lygūs? 
            //1.3. Ar pirmas skaičius yra didesnis už antrąjį? 
            //1.4. Ar antras skaičius yra didesnis už dvigubą trečiojo skaičiaus reikšmę (trečias skaičius padaugintas iš 2)? 
            //1.5. Ar pirmas skaičius yra lyginis (ar dalinasi iš 2)? 
            //1.6. Ar antras skaičius yra nelyginis (ar nesidalina iš 2)? 
            //1.7. Ar trečias skaičius yra teigiamas (didesnis už 0)? 
            //1.8. Ar pirmas skaičius yra neigiamas (mažesnis už 0)? 
            //1.9. Ar antras skaičius dalinasi iš 4? 
            //1.10. Ar trečias skaičius dalinasi iš 8?

            Console.WriteLine("Iveskite tris skaicius.");
            Console.Write("sk1 = ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sk2 = ");
            var sk2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sk3 = ");
            var sk3 = Convert.ToInt32(Console.ReadLine());

            if (sk1 ==sk2)
            {
                Console.WriteLine("Skaiciai {0} ir {1} yra lygus", sk1, sk2);
            }

            if (sk2 == sk3)
            {
                Console.WriteLine("Skaiciai {0} ir {1} yra lygus", sk2, sk3);
                            }

            if (sk1 > sk2)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz {1}", sk1, sk2);
            }

            if (sk2 > sk3*2)
            {
                Console.WriteLine("Skaicius {0} yra didesnis uz dviguba skaiciu {1} ", sk2, sk3);
            }

            if (sk1%2 ==0)
            {
                Console.WriteLine("Skaicius {0} yra lyginis", sk1);
            }

            if (sk2 % 2 != 0)
            {
                Console.WriteLine("Skaicius {0} yra nelyginis", sk2);
            }

            if (sk3 > 0)
            {
                Console.WriteLine("Skaicius {0} yra teigiamas", sk3);
            }

            if (sk1 < 0)
            {
                Console.WriteLine("Skaicius {0} yra neigiamas", sk1);
            }

            if (sk2 % 4 == 0)
            {
                Console.WriteLine("Skaicius {0} dalinasi is keturiu", sk2);
            }

            if (sk3 % 8 == 0)
            {
                Console.WriteLine("Skaicius {0} dalinasi is astuoniu", sk3);
            }

        }
    }
}
