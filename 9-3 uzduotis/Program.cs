using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nekeliant į naujas eilutes, kiekvieną skaičių atskiriant kableliu išveskite visus skaičius nuo 1 iki 100. 

            var sk = 1;

            while (sk<100)
            {
                Console.Write(sk + ", ");
                sk++;
            }

        }
    }
}
