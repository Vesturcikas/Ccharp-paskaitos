using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite penkis skaicius:");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());
            var sk3 = Convert.ToInt32(Console.ReadLine());
            var sk4 = Convert.ToInt32(Console.ReadLine());
            var sk5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ivestu skaiciu vidurkis: {0}.", (double) (sk1+sk2+sk3+sk4+sk5)/5);
        }
    }
}
