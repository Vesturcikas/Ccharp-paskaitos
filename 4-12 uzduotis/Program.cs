using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());
            var sk3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaiciaus {0} kvadratas: {1}; kubas: {2}; {0}/2 = {3}.", sk1, Math.Pow(sk1, 2), Math.Pow(sk1, 3), (double) sk1 / 2);
            Console.WriteLine("Skaiciaus {0} kvadratas: {1}; kubas: {2}; {0}/2 = {3}.", sk2, Math.Pow(sk2, 2), Math.Pow(sk2, 3), (double) sk2 / 2);
            Console.WriteLine("Skaiciaus {0} kvadratas: {1}; kubas: {2}; {0}/2 = {3}.", sk3, Math.Pow(sk3, 2), Math.Pow(sk3, 3), (double) sk3 / 2);

        }
    }
}
