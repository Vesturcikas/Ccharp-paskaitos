using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Išvedinėkite visus skaičius nuo 1 iki tol kol pasitaikys skaičius, kuris dalinasi iš 3 ir iš 5. 

            var sk = 1;

            while (sk % 3 == 0 && sk % 5 == 0)
            {
                Console.WriteLine(sk);
                sk++;

            }
            Console.WriteLine("Radome skaiciu kuris dalinasi is 3 ir 5");
        }
    }
}
