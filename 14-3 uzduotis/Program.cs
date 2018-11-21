using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurkite ir iškvieskite metodą, kuris išvestų norimus žodžius atskirose eilutėse, 
            //prieš kiekvieną žodį parašant brūkšnį. Pavyzdžiui: - pirmas - antras 

            var keit = new Program();

            keit.zodis();

        }

        public void zodis()
        {
            Console.Write("Iveskite norima zodi: ");
            var zod = Console.ReadLine();
            Console.WriteLine("-" + zod);

        }

    }
}
