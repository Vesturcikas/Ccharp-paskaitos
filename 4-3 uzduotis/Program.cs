using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite duomenis apie savo augintini.");
            Console.Write("Augintinio rusis: ");

            var Rus = Console.ReadLine();

            Console.Write("Augintinio amzius (metais): ");

            var Amz = Console.ReadLine();

            Console.WriteLine("Jusu {0} yra {1} metu.", Rus, Amz);

        }
    }
}
