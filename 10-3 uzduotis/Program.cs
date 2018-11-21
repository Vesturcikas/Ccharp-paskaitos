using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Išveskite visus lyginius skaičius nuo 1 iki pirmojo, kuris dalinasi iš 20. Iš visų šių išvestų skaičių sumą. 

            var sk1 = 1;
            var sum = 0;

            do
            {
                Console.WriteLine(sk1);
                sum += sk1;
                                sk1++;
            } while (sk1%20!=0);

            Console.WriteLine("Isvestu skaiciu suma lygi: " + sum);
        }
    }
}
