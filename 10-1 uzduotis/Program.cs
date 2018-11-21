using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Išveskite visus skaičius nuo 1 iki pirmojo, kuris dalinasi iš 17.

            var sk1 = 1;

            do
            {
                Console.WriteLine(sk1);
                                                sk1++;
            } while (sk1%17 !=0);

        }
    }
}
