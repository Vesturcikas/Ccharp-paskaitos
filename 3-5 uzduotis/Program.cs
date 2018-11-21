using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk1 = 20;
            var sk2 = 8;
            var suma = sk1 + sk2;
            var skirt = sk1 - sk2;
            var sand = sk1 * sk2;
            var dalm = sk1 / sk2;

            Console.WriteLine("{0} + {1} = {2};", sk1, sk2, suma);
            Console.WriteLine("{0} - {1} = {2};", sk1, sk2, skirt);
            Console.WriteLine("{0} * {1} = {2};", sk1, sk2, sand);
            Console.WriteLine("{0} / {1} = {2};", sk1, sk2, dalm);
            Console.WriteLine("{0} % {1} = {2};", sk1, sk2, sk1 % sk2);



        }
    }
}
