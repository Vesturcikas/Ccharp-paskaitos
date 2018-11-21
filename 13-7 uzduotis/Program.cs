using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurkite ir užpildykite sąrašą su šimtu atsitiktinių skaičių. 
            //Išveskite visus sugeneruotus skaičius, juos atskiriant tarpu. 
            //Raskite ir išveskite: 
            //7.1. Paskutinis skaičius. 
            //7.2. Atsitiktinis skaičius. 
            //7.3. Mažiausias skaičius. 
            //7.4. Didžiausias skaičius. 
            //7.5. Skaičių suma. 
            //7.6. Skaičių vidurkis. 
            //7.7. Lyginių skaičių kiekis.
     
            var atsitiktinis = new Random();
            List <int> SkSar = new List <int> ();

            int SkMin = 1000;
            int SkMax = 0;
            int SkSum = 0;
            int SkLK = 0;

            for (int i = 0; i < 100; i++)
            {
                SkSar.Add(atsitiktinis.Next(1, 100));

            }

            //Duomenu isvedimas:

            Console.WriteLine("Sugeneruotas 100 nariu sarasas:");
            Console.WriteLine();

            foreach (var sk in SkSar)
            {
                Console.Write(sk + ", ");
                SkSum += sk;
                if (sk<SkMin)
                {
                    SkMin = sk;
                }
                else if (sk>SkMax)
                {
                    SkMax = sk;
                }
                else if (sk%2==0)
                {
                    SkLK++;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Paskutinis saraso skaicius: " + SkSar.Last());
            Console.WriteLine();
            Console.WriteLine("Atsitiktinis saraso skaicius: " + SkSar[atsitiktinis.Next(0,100)]);
            Console.WriteLine();
            Console.WriteLine("Maziausias saraso skaicius: " + SkMin);
            Console.WriteLine();
            Console.WriteLine("Didziausias saraso skaicius: " + SkMax);
            Console.WriteLine();
            Console.WriteLine("Saraso skaiciu suma: " + SkSum);
            Console.WriteLine();
            Console.WriteLine("Saraso skaiciu vidurkis: " + (double)SkSum/100);
            Console.WriteLine();
            Console.WriteLine("Sarase yra {0} lyginiu skaiciu.", SkLK);

        }
    }
}
