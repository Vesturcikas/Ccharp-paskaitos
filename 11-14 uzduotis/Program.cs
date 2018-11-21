using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_14_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Susikurkite kintamąjį, kuris nusakytų kiek fibonačiaus skaičių turi būti sugeneruota. 
            //Užpildykite skaičių masyvą su tiek fibonačiaus skaičių kiek buvo nurodyta. 
            //Išveskite masyve esančius skaičius toje pačioje eilutėje, skaičius atskiriant kableliu. 

                       
            int k; 
                      
            do
            {
                Console.Write("Iveskite kiek Fibonaciaus skaiciu sugeneruoti (maks 46): ");
                k = Convert.ToInt32(Console.ReadLine());
                if (k > 46)
                {
                    Console.WriteLine("Tiek Fibonacio skaiciu negalime suskaiciuoti!!!");
                                
                }
            } while (k > 46);          
                              
                       
            long[] FibonMasyvas = new long[k];
            int sk1 = 1;
            int sk2 = 1;
            int sk3;

            for (int i = 0; i < FibonMasyvas.Length; i++)
            {
                if (i==0)
                {
                    FibonMasyvas[i] = sk1;
                    continue;
                }
                else if (i==1)
                {
                    FibonMasyvas[i] = sk2;
                    continue;
                }
                
                sk3 = sk1 + sk2;
                sk1 = sk2;
                sk2 = sk3;
                FibonMasyvas[i] = sk3;
            }

            Console.Write("Jusu pasirinkto kiekio Fiboncio skaiciai: ");


            foreach (var fsk in FibonMasyvas)
            {
                Console.Write(fsk + ", ");
            }

        }
    }
}
