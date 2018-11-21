using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite savo varda: ");
            var Vard = Console.ReadLine();
            Console.Write("Iveskite savo amziu: ");
            var Amz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jus esate {0}. Jums {1} metu.", Vard, Amz);
            

        }
    }
}
