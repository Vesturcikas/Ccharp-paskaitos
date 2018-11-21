using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius.");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaiciu {0} ir {1} suma: {2}.", sk1, sk2, sk1 + sk2);
        }
    }
}
