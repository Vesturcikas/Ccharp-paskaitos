using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Išvedinėkite atsitiktinius skaičius iki kol rasite skaičių, kuris dalinasi iš 3.

            var rand = new Random();
            var sk1 = 1;
            do
            {
                                sk1 = rand.Next(1, 100);
                Console.WriteLine(sk1);
            } while (sk1%3!=0);

        }
    }
}
