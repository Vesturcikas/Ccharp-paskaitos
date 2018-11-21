using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Išveskite visus nelyginius skaičius nuo 1 iki 50. Raskite šių skaičių sumą ir vidurkį. 

            var sk1 = 1;
            var sum = 0;
            var kiek = 0;
           
            do
            {
                if (sk1%2!=0)
                {
                    Console.WriteLine(sk1);
                    sum += sk1;
                    kiek++;
                }

                sk1++;
            } while (sk1<=60);

            Console.WriteLine("Nelyginiu skaiciu suma: " + sum);
            Console.WriteLine("Nelyginiu skaiciu viduris: " + (double)sum / kiek);

        }
    }
}
