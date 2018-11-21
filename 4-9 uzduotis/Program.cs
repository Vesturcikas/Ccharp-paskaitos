using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius:");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", sk1, sk2, sk1 + sk2);
            Console.WriteLine("{0} * {1} = {2}", sk1, sk2, sk1 * sk2);
            Console.WriteLine("{0} / {1} = {2}", sk1, sk2, sk1 / sk2);
        }
    }
}
