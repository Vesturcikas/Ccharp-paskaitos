using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvedinėti bet kokius skaičius. 
            //Vykdykite įvedinėjimą iki kol įvestas skaičius bus lygus 0. Raskite įvestų skaičių sumą.

            var sk = 1;
            var sum = 0;

            Console.WriteLine("Iveskite bet kokius skaicius, jei norite baigti, iveskite 0.");

            while (sk != 0)
            {
                Console.Write("Jusu skaicius: ");
                sk = Convert.ToInt32(Console.ReadLine());
                sum += sk;
                continue;
            }

            Console.WriteLine("Ivestu skaiciu suma: " + sum);
        }
    }
}
