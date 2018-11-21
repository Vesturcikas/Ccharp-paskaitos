using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parašykite ir iškvieskite metodą, kuris per argumentus priimtų skaičių sąrašą. Metodas turi rasti ir išvesti mažiausią rastą skaičių.

            var m = new Program();
            var ats = new Random();

            List<int> sarasas = new List<int>();

            Console.Write("Iveskite saraso ilgi: ");

            var sarIlgis = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sarIlgis; i++)
            {
                sarasas.Add(ats.Next(100));
            }

            m.sarIsv(sarasas);
            Console.WriteLine();

            m.sarMin(sarasas);

        }

        public void sarIsv (List<int> sarasas)
        {
            Console.Write("Buvo sugeneruotas toks skaiciu sarasas: ");
            foreach (var sk in sarasas)
            {
                Console.Write(sk + " ");
            }
        }
               
        public void sarMin (List<int> sarasas)
        {
            var min = 100000000;

            foreach (var sk in sarasas)
            {
                if (sk<min)
                {
                    min = sk;
                }
            }

            Console.WriteLine("Maziausias rastas skaicius is duoto saraso: " + min);
        }


    }
}
