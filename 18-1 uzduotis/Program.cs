using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_1_uzduotis
{
    class Korta
    {

        /// <summary>
        /// 
        /// </summary>
        public string Simbolis { get; } // konstruojant objekta suteiksime tik reiksmes
        public string Skaicius { get; }

        public Korta(string simbolis, string skaicius)
        {
            Simbolis = simbolis;
            Skaicius = skaicius;
           
        }



        #region Private methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simboliai"></param>
        /// <param name="atst"></param>
        /// <param name="kalade"></param>
        /// <returns></returns>
        private static List<Korta> Rekursija(string[] simboliai, Random atst, List<Korta> kalade)
        {

            Korta korta = new Korta(simboliai[atst.Next(0, 4)], skaiciai[atst.Next(0, 13)]);
            bool vienoda = false;
            foreach (var kort in kalade)
            {
                if (kort.Simbolis == korta.Simbolis && kort.Skaicius == korta.Skaicius)
                {
                    vienoda = true;
                    break;
                }

                if (vienoda)
                {
                    kalade.Add(korta);
                }

                if (kalade.Count < 52)
                {
                    Rekursija(simboliai, atst, kalade);
                }
                else
                {
                    return kalade;
                }


            }




        }
        #endregion

    }

       
    class Program
    {
        static void Main(string[] args)
        {
            //Sudaryti ismaisyta kortu kalade (52 kortos)

            var atst = new Random();

            
            string[] simboliai = { "Cirvai", "Bugnai", "Kryziai", "Pikai" };
            string[] skaiciai = { "T", "2", "3", "4", "5", "6", "7", "8", "9", "10", "B", "D", "K" };

            // Korta korta = new Korta(simboliai[atst.Next(0, 4)], skaiciai[atst.Next(0, 13)]);

            //Console.WriteLine(korta.Simbolis + " " + korta.Skaicius);

            List<Korta> kalade = new List<Korta>();

            /* while (kalade.Count <52)
             {
                 Korta korta = new Korta(simboliai[atst.Next(0, 4)], skaiciai[atst.Next(0, 13)]);
                 bool vienoda = false;
                 foreach (var kort in kalade)
                 {
                     if (kort.Simbolis == korta.Simbolis && kort.Skaicius == korta.Skaicius)
                     {
                         vienoda = true;
                         break;
                     }

                     if (vienoda)
                     {
                         kalade.Add(korta);
                     }

                 }*/


            kalade.Rekursija(simboliai, atst, kalade);

            foreach (var kort in kalade)
            {
                Console.WriteLine(kort);
            }





        }

       
    }
}
