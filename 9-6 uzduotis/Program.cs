using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Išveskite 10 atsitiktinių skaičių, raskite jų sumą. 

            var rand = new Random();
            var sk = 1;
            var sum = 0;
            while (sk<=10)
            {
                var skaicius = rand.Next(1, 100);
                Console.WriteLine(skaicius);
                sum += skaicius;
                sk++;
            }
            Console.WriteLine("Visu atsitiktiniu skaiciu suma: " + sum);
        }
    }
}
