using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parašyti for ciklą, kuris išvestų norimą kiekį fibonačiaus skaičių į ekraną. 
            //Fibonačiaus sekoje kiekvienas skaičius yra lygus prieš jį ėjusių dviejų skaičių sumai: 1, 1, 2, 3, 5, 8, 13, 21… 

            Console.Write("Iveskite kiek Fibanaciaus skaiciu isvesti: ");
            var Skpab = Convert.ToInt32(Console.ReadLine());

            var sk1 = 1;
            var sk2 = 0;
            var sk3 = 0;

            for (int i = 1; i < Skpab; i++)
            {
                Console.Write(sk3 + ", ");
                sk3 = sk1 + sk2;
                sk1 = sk2;
                sk2 = sk3;
            }

        }
    }
}
