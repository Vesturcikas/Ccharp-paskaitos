using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Susikurkite du skaičių masyvus. 
            //Raskite kiekvieno iš jų skaičių sumas. 
            //Palyginkite, kurio masyvo skaičių suma yra didesnė. 
            //Nenaudokite sumos ieškojimo funkcijos (Sum()). 

            var rand = new Random();

            Console.Write("Iveskite pirmo masyvo dydi (maks 10): "); //uzklausiama pirmo masyvo dydzio
            var k1 = Convert.ToInt32(Console.ReadLine());
            int[] masyvas1 = new int[k1];

            Console.Write("Iveskite antro masyvo dydi (maks 10): "); //uzklausiama pirmo antro dydzio
            var k2 = Convert.ToInt32(Console.ReadLine());
            int[] masyvas2 = new int[k2];

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < masyvas1.Length; i++) //suformuojams pirmas masyvas
            {
                masyvas1[i] = rand.Next(1, 100);
            }

            Console.WriteLine("Is atsitiktiniu skaiciu buvo sugeneruotas pirmas masyvas: "); //pirmo masyvo atspausdinimas
            Console.Write("{ ");

            /*for (int i = 0; i < masyvas1.Length; i++)
            {
                Console.Write(masyvas1[i] + ", ");
                sum1 += masyvas1[i];
            }*/

            foreach (var sk1 in masyvas1)
            {
                Console.Write(sk1 + ", ");
                sum1 += sk1;
            }

            Console.WriteLine("}");
            Console.WriteLine();

            for (int i = 0; i < masyvas2.Length; i++) //suformuojams antras masyvas
            {
                masyvas2[i] = rand.Next(1, 100);
            }

            Console.WriteLine("Is atsitiktiniu skaiciu buvo sugeneruotas antras masyvas: "); //isvedamas antras masyvas
            Console.Write("{ ");

            /*for (int i = 0; i < masyvas2.Length; i++)
            {
                Console.Write(masyvas2[i] + ", ");
                sum2 += masyvas2[i];
            }*/

            foreach (var sk2 in masyvas2)
            {
                Console.Write(sk2 + ", ");
                sum2 += sk2;
            }

            Console.WriteLine("}");
            Console.WriteLine();

            Console.WriteLine("Pirmo masyvo nariu suma: " + sum1);
            Console.WriteLine();
            Console.WriteLine("Antro masyvo nariu suma: " + sum2);
            Console.WriteLine();

            if (sum1<sum2)
            {
                Console.WriteLine("Antro masyvo nariu suma {0} yra didesne uz pirmo masyvo nariu suma {1}.", sum2, sum1);
            }
            else if (sum1 > sum2)
            {
                Console.WriteLine("Pirmo masyvo nariu suma {0} yra didesne uz antro masyvo nariu suma {1}.", sum1, sum2);
            }
            else if (sum1==sum2)
            {
                Console.WriteLine("Abieju masyvu nariu sumos yra lygios: {0} = {1}.", sum1, sum2);
            }

                                 
        }
    }
}
