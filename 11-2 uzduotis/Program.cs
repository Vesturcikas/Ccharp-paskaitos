using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Susikurkite skaičių masyvą, kurį užpildykite atsitiktiniais skaičiais. 
            //Išveskite visus skaičius su indeksais į atskiras eilutes. 
            //Pavyzdžiui: 
            //indekse 0 yra 8 
            //indekse 1 yra 2 
            //indekse 2 yra 7 

            var rand = new Random();

            Console.Write("Iveskite masyvo dydi: ");
            var k = Convert.ToInt32(Console.ReadLine());

            int[] skaiciai = new int[k];

            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = rand.Next(1, 100);
                            }
            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.WriteLine("indekse {0} yra {1}", i, skaiciai[i]);
            }


        }
    }
}
