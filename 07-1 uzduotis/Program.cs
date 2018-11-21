using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Išveskite vartotojui pasirinkimų informaciją
            //(pavyzdžiui: pasirinkite 1, jei vanduo, 2 - jei …, 3 - jei ...). 
            //Liepkite vartotojui įvesti pasirinkimo numerį. 
            //Tikrinkite: 
            //1.1. Ar pasirinkimas lygus 1? Jei taip, išveskite, kad vartotojas pasirinko vandenį. 
            //1.2. Ar pasirinkimas lygus 2? Jei taip, išveskite, kad vartotojas pasirinko limonadą. 
            //1.3. Ar pasirinkimas lygus 3? Jei taip, išveskite, kad vartotojas pasirinko arbatą. 
            //1.4. Ar pasirinkimas lygus 4? Jei taip, išveskite, kad vartotojas pasirinko kavą. 
            //1.5. Jei pasirinkimas neegzistuoja, išveskite klaidos pranešimą.

            Console.WriteLine("Pasirinkite gerimo numeri: 1-vanduo; 2-limonadas; 3-arbata; 4-kava.");
            var sk1 = Convert.ToInt32(Console.ReadLine());

            switch (sk1)
            {
                case 1: Console.WriteLine("Jus pasirinkote gerti vandeni. Vandeni atnesime tuoj."); break;
                case 2: Console.WriteLine("Jus pasirinkote gerti limonada. Limonada atnesime po 5 min."); break;
                case 3: Console.WriteLine("Jus pasirinkote gerti arbata. Arbata atnesime po 10 min."); break;
                case 4: Console.WriteLine("Jus pasirinkote gerti kava. Kava atnesime po 15 min."); break;
                default: Console.WriteLine("Jus nieko nepasirinkote."); break;
            }

        }
    }
}
