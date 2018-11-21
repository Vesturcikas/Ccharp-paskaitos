using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk1 = 5;
            var sk2 = 6;
            var sk3 = 8;
            var sk4 = 7;

            Console.WriteLine("Skaiciu: {0}, {1}, {2} ir {3} vidurkis yra: {4}", sk1, sk2, sk3, sk4, (double) (sk1 + sk2 + sk3 + sk4) / 4);

        }
    }
}
