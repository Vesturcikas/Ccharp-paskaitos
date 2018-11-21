using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Raskite visų lyginių skaičių nuo 20 iki 50 sumą.

            var sum = 0;

            for (int i = 20; i < 50; i++)
            {
                if (i%2==0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Lyginiu skaiciu nuo 20 iki 50 suma: " + sum);

        }
    }
}
