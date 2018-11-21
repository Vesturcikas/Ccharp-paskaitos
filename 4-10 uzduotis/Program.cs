using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());
            var sk3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaiciu: {0}, {1} ir {2} vidurkis: {3}", sk1, sk2, sk3, (double)(sk1 + sk2+sk3)/3);
        }
    }
}
