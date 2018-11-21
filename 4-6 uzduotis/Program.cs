using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite bet koki skaiciu: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skaiciaus {0} kvadratas: {1}.", sk1, Math.Pow(sk1, 2));
        }
    }
}
