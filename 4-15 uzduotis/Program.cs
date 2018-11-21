using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_15_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite varda: ");
            var Vard = Console.ReadLine();
            Console.Write("Iveskite pavarde: ");
            var Pavard = Console.ReadLine();
            Console.Write("Iveskite gimimo metus: ");
            var Gim = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite savo specialybe: ");
            var Spec = Console.ReadLine();
            Console.Write("Kokiu etatu dirbate (nuo 0 iki 1)? ");
            var Etat = Convert.ToInt16(Console.ReadLine());
            Console.Write("Kokia Jusu alga (Eur)? ");
            var Alg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aciu uz duomenis. Tuoj viska suskaiciuosime ir pateiksime rezultatus:)");
            Console.WriteLine("{0} {1}, kuriam {5} metai, dirba {2} {3} etatu ir gauna {4} euru atlyginima.",
                Vard, Pavard, Spec, Etat, Alg, (2018 - Gim));
        }
    }
}
