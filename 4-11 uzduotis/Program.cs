using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite bet koki skaiciu: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaiciaus {0} daugybos lentele nuo 1 iki 5:", sk1);
            Console.WriteLine("{0} * 1 = {1};", sk1, sk1 * 1);
            Console.WriteLine("{0} * 2 = {1};", sk1, sk1 * 2);
            Console.WriteLine("{0} * 3 = {1};", sk1, sk1 * 3);
            Console.WriteLine("{0} * 4 = {1};", sk1, sk1 * 4);
            Console.WriteLine("{0} * 5 = {1};", sk1, sk1 * 5);

        }
    }
}
