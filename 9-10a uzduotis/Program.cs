using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10a_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Išveskite skaičius nuo 1 iki 50. 
            //Šalia skaičiaus parašykite iš kokių skaičių (1-9) jis dalinasi. 
            //Pavyzdžiui: 
            //Skaičius 2 dalinasi iš: 2 
            //Skaičius 3 dalinasi iš: 3 
            //Skaičius 4 dalinasi iš: 2 4 

            var i = 1;
            var j = 1;

            while (i<=50)
            {
                j = 1;
                Console.Write("Skaicius {0} dalinasi is: ", i);
                while (j<=9)
                {
                    if (i%j==0)
                    {
                        Console.Write(j + ", ");
                    }

                    j++;
                }
                Console.WriteLine();
                i++;
            }



        }
    }
}
