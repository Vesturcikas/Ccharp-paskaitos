using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Išveskite visus skaičius nuo 1 iki pirmojo, kuris dalinasi iš 100. 
            //Vietoj kiekvieno skaičiaus, kuris dalinasi iš 5 išveskite tekstą “skaičius dalinasi iš 5”. 

            var sk1 = 1;

            do
            {
                if (sk1%5==0)
                {
                    Console.WriteLine("Skaicius dalinasi is 5.");
                }
                else
                {
                    Console.WriteLine(sk1);
                }
                sk1++;
            } while (sk1%100!=0);

        }
    }
}
