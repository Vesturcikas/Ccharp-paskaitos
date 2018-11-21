using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iš skaičių nuo 1 iki 100, raskite visų lyginių ir visų nelyginių skaičių sumas. Naudokite tą patį ciklą abiems šiems veiksmams.

            var sk = 1;
            var sumL = 0;
            var sumN = 0;

            while (sk<=100)
            {
                if (sk%2==0)
                {
                    sumL += sk;
                }
                else
                {
                    sumN += sk;
                }
                sk++;
            }
            Console.WriteLine("Lyginiu sk suma: " + sumL);
            Console.WriteLine("Nelyginiu sk suma: " + sumN);
        }
    }
}
