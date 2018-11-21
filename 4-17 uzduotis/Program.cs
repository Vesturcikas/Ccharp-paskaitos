using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_17_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmo automobilio duomenis:");
            Console.Write("1. automobilio markė: ");
            var marke1 = Console.ReadLine();
            Console.Write("2. automobilio modelis: ");
            var model1 = Console.ReadLine();
            Console.Write("3. automobilio metai: ");
            var metai1 = Console.ReadLine();
            Console.Write("4. darbinis tūris (l): ");
            var dturis1 = Console.ReadLine();
            Console.Write("5. Ar galioja TA? (true/false): ");
            var TA1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Įveskite antro automobilio duomenis:");
            Console.Write("1. automobilio markė: ");
            var marke2 = Console.ReadLine();
            Console.Write("2. automobilio modelis: ");
            var model2 = Console.ReadLine();
            Console.Write("3. automobilio metai: ");
            var metai2 = Console.ReadLine();
            Console.Write("4. darbinis tūris (l): ");
            var dturis2 = Console.ReadLine();
            Console.Write("5. Ar galioja TA? (true/false): ");
            var TA2 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("+---------+-------------+-------------+---------+-----------------+-----------------+");
            Console.WriteLine("| Eil. Nr.|   Markė     |   Modelis   |  Metai  | Darb. tūris (l) | TA (true/false) |");
            Console.WriteLine("+---------+-------------+-------------+---------+-----------------+-----------------+");
            Console.WriteLine("|   1.    | {0,11} | {1,11} | {2,7} | {3,15} | {4,15} |", marke1, model1, metai1, dturis1, TA1);
            Console.WriteLine("+---------+-------------+-------------+---------+-----------------+-----------------+");
            Console.WriteLine("|   2.    | {0,11} | {1,11} | {2,7} | {3,15} | {4,15} |", marke2, model2, metai2, dturis2, TA2);
            Console.WriteLine("+---------+-------------+-------------+---------+-----------------+-----------------+");

        }
    }
}
