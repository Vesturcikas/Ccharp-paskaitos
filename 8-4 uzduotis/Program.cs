using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parašyti for, kuris eitų pro kiekvieną skaičių nuo 1 iki 10. 
            //Jame apsirašyti if sąlygą, kuri patikrintų ar dabartinis skaičius yra lyginis, jei taip tai šį skaičių išvesti. 

            for (int i = 1; i < 10; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
