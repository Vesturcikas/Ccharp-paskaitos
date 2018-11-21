using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk = 48;
            var sk1 = sk / 10;
            var sk2 = sk % 10;

            Console.WriteLine("Skaiciaus {0} skaitmenu suma: {1} + {2} = {3}.", sk, sk1, sk2, sk1 + sk2);


        }
    }
}
