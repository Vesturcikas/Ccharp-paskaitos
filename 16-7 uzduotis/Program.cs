using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parašykite šiuos metodus: 
            //7.1. Priimtų skaičių masyvą, grąžintų mažiausią rastą skaičių. 
            //7.2. Priimtų skaičių masyvą, grąžintų didžiausią rastą skaičių. 
            //7.3. Priimtų skaičių masyvą, grąžintų sumą. 
            //7.4. Priimtų sumą ir kiekį, grąžintų vidurkį. 
            //7.5. Priimtų skaičių masyvą, iškviestų visus ankstesnius metodus, 
            //     išvedant visus papildomus tekstus, kurie apibūdintų atliktus skaičiavimus ir gautus rezultatus.



        }

        public void veikMasyv(int[] masyvas)
        {
            Console.WriteLine("Maziausias masyvo skaicius: ", minMasyvo(masyvas));
            Console.WriteLine();
            Console.WriteLine("Didziausias masyvo skaicius: ", maxMasyvo(masyvas));
            Console.WriteLine();
            Console.WriteLine("Masyvo skaiciu suma: ", sumMasyvo(masyvas));
            Console.WriteLine();
            Console.WriteLine("Maziausia masyvo skaicius: ", minMasyvo(masyvas));
            Console.WriteLine();


        }






        public int minMasyvo (int[] masyvas)
        {
            var min = 10000000;
            foreach (var sk in masyvas)
            {
                if (sk<min)
                {
                    min = sk;
                }
            }

            return min;
        }

        public int maxMasyvo(int[] masyvas)
        {
            var max = 0;
            foreach (var sk in masyvas)
            {
                if (sk < max)
                {
                    max = sk;
                }
            }

            return max;
        }

        public int sumMasyvo(int[] masyvas)
        {
            var sum = 0;
            foreach (var sk in masyvas)
            {
                sum += sk;
            }

            return sum;
        }

        public double vidMas(int suma, int kiekis)
        {
            double vid = (double)suma / kiekis;
            return vid;
        }



    }
}
