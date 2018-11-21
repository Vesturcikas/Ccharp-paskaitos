using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nekeliant į atskiras eilutes, o atskiriant kableliu išveskite 100 atsitiktinių skaičių. Raskite visų jų sumą ir vidurkį. 

            var rand = new Random();
            var sk = 1;
            var sum = 0;
            double vid = 0.0;

            while (sk<=100)
            {
                var atsitiktinis = rand.Next(1, 100);

                Console.Write(atsitiktinis + ", ");
                sum += atsitiktinis;
                vid = (double)sum / sk;

                sk++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Atsiktiniu skaiciu suma: " + sum);
            Console.WriteLine();
            Console.WriteLine("Atsikitiniu skaiciu vidurkis: " + vid);

        }
    }
}
