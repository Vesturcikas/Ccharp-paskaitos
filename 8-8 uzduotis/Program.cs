using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Raskite visų skaičių nuo 1 iki 100 sumą.

            var sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            Console.WriteLine("skaiciu nuo 1 iki 100 suma: " + sum);

        }
    }
}
