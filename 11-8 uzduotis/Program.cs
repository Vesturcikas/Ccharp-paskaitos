using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Susikurkite skaičių masyvą.
            //Suskaičiuokite skaičių sumą, vidurkį.
            //Nenaudokite “greitųjų” radimo funkcijų(Sum() ir Average()).

            var rand = new Random();

            Console.Write("Iveskite masyvo dydi (maks 10): ");
            var k = Convert.ToInt32(Console.ReadLine());

            int[] skaiciai = new int[k];

            int sum = 0;
            

            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = rand.Next(1, 100);
            }

            /*for (int i = 0; i < skaiciai.Length; i++)
            {
                sum += skaiciai[i];
            }*/

            foreach (var sk in skaiciai)
            {
                sum += sk;
            }

            Console.WriteLine("Buvo sugeneruotas toks skaiciu masyvas: ");
            Console.Write("{ ");

            /*for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.Write(skaiciai[i]+", ");
            }*/

            foreach (var sk in skaiciai)
            {
                Console.Write(sk + ", ");
            }


            Console.WriteLine("}");

            Console.WriteLine("Sio masyvo nariu suma: " + sum);
            Console.WriteLine("Sio masyvo nariu vidurkis: " + (double)sum / k);

        }
    }
}
