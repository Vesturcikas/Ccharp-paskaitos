using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti trijų egzaminų rezultatus. 
            //Suraskite pažymių vidurkį. 
            //Atlikite šiuos patikrinimus: 
            //6.1. ar gautas vidurkis yra [8-10]; 
            //6.2. ar gautas vidurkis yra [5-8); 
            //6.3. ar gautas vidurkis yra < 5. 

            Console.WriteLine("Iveskite tris egzamino rezultatus.");
            Console.Write("sk1 = ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sk2 = ");
            var sk2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sk3 = ");
            var sk3 = Convert.ToInt32(Console.ReadLine());

            double vid = (double)(sk1 + sk2 + sk3) / 3;

            if (8 <= vid && vid <= 10)
            {
                Console.WriteLine("Jusu egzaminu vidurkis: {0}, todel galite studijuoti universitete.", vid);
            }
            else if (5 <= vid && vid < 8)
            {
                Console.WriteLine("Jusu egzaminu vidurkis: {0}, todel galite mokintis kolegijoje.", vid);
            }
            else
            {
                Console.WriteLine("Jusu egzaminu vidurkis: {0}, todel liekate mokintis mokykloje.");
            }

            
        }

        
    }
}
