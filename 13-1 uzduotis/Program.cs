using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurkite sąrašą skaičiams saugoti ir jį užpildykite duomenimis. 
            //Raskite ir išveskite mažiausią skaičių.

            List<int> SkaicSarasas = new List<int> ();

            int SkMin= 1000;
            int iMin = 0;

            Console.Write("Kiek saraso nariu tures jusu sarasas? ");
            var kiek = Convert.ToInt32(Console.ReadLine());

            // Saraso suformavimas

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("Iveskite saraso skaiciu: ");
                SkaicSarasas.Add(Convert.ToInt32(Console.ReadLine()));
            }

            // Minimumo ieskojimas

            for (int i = 0; i < kiek; i++) 
            {
                if (i==0)
                {
                    SkMin = SkaicSarasas[i];
                    iMin = 0;
                }
                if (SkaicSarasas[i] < SkMin)
                {
                    SkMin = SkaicSarasas[i];
                    iMin = i;
                }
             
            }

            // Duomenu isvedimas

            Console.WriteLine("Jusu sukurtas skaiciu sarasas:");

            foreach (var k in SkaicSarasas)
            {
                Console.Write(k + ", ");
            }

            Console.WriteLine();

            Console.Write("Maziausias saraso naris: {0}. Jo indeksas sarase: {1} ir jis yra {2} sarase.", SkMin, iMin, iMin + 1);




        }
    }
}
