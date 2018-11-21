using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Išveskite visus skaičius nuo 1 iki 50. 
            //Prie kiekvieno lyginio skaičiaus parašykite žodį „lyginis“, o prie kiekvieno nelyginio – „nelyginis“. 

            var sk = 1;

            while (sk<=50)
            {
                Console.Write(sk);
                if (sk%2==0)
                {
                    Console.Write(" lyginis");

                }
                else
                {
                    Console.Write(" nelyginis");
                }
                sk++;
                Console.WriteLine();
            }

        }
    }
}
