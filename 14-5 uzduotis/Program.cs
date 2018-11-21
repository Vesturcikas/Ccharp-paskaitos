using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurkite ir iškvieskite metodą, kuris sugeneruotų lentelę. 
            //Pirmame ir antrame stulpeliuose turi būti atsitiktinai sugeneruoti skaičiai, 
            //o trečiame stulpelyje - tos eilutės skaičių suma. 

            var lent = new Program();
            lent.lentele();


        }

        public void lentele()
        {
            var atsSk = new Random();

            Console.Write("Iveskite kiek norite tureti eiluciu lenteleje: ");
            var k = Convert.ToInt32(Console.ReadLine());

            int[] stulp1 = new int[k];
            int[] stulp2 = new int[k];
            int[] stulp3 = new int[k];

            for (int i = 0; i < k; i++)
            {
                stulp1[i] = atsSk.Next(0, 1000);
                stulp2[i] = atsSk.Next(0, 1000);
                stulp3[i] = stulp1[i] + stulp2[i];
            }
            Console.WriteLine("+------------+------------+------------+");
            Console.WriteLine("| Stulpelis1 | Stulpelis2 | Suma       |");
            Console.WriteLine("+------------+------------+------------+");

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("|{0, 12}|{1, 12}|{2, 12}|", stulp1[i], stulp2[i], stulp3[i]);
            }

            Console.WriteLine("+------------+------------+------------+");
        }



    }
}
