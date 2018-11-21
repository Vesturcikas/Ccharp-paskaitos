using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be daugybos veiksmo programoje, sudauginti du skaičius.

            Console.WriteLine("Iveskite du skaicius, kuriuos sudauginsime.");
            Console.Write("sk1: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sk2: ");
            var sk2 = Convert.ToInt32(Console.ReadLine());

            var sum = 0;

            for (int i = 1; i <= sk1; i++)
            {
                for (int j = 1; j <= sk2; j++)
                {
                    sum = sum + 1;
                }
            }

            Console.WriteLine("{0} * {1} = {2}", sk1, sk2, sum);
        }
    }
}
