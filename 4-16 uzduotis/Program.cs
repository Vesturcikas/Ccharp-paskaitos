using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_16_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite studento varda: ");
            var Vard = Console.ReadLine();
            Console.Write("Iveskite studento pavarde: ");
            var Pavard = Console.ReadLine();
            Console.Write("Iveskite grupes koda: ");
            var GrKod = Console.ReadLine();
            Console.Write("Iveskite Aukstosios mokyklos pavadinima: ");
            var Pavad = Console.ReadLine();
            Console.WriteLine("Suveskite penkis studento pazymius:");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());
            var sk3 = Convert.ToInt32(Console.ReadLine());
            var sk4 = Convert.ToInt32(Console.ReadLine());
            var sk5 = Convert.ToInt32(Console.ReadLine());
            double Vid = (sk1 + sk2 + sk3 + sk4 + sk5) / 5;
            Console.WriteLine("Studento {0} {1}, kuris mokosi {2} aukstojoje mokykloje, {3} grupeje, pazymiu vidurkis: {4}.",
                Vard, Pavard, Pavad, GrKod, (double) Vid);

        }
    }
}
