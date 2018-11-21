using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Raskite visų skaičių nuo 1 iki 10 sandaugą. Išveskite tik atsakymą, neišvedant pačių skaičių.

            var kiekis = 1;
            var sand = 1;

            while (kiekis<=10)
            {
                sand = sand * kiekis;

                kiekis++;

            }

            Console.WriteLine("Skaiciu nuo 1 iki 10 sandauga: " + sand);

            
        }
    }
}
