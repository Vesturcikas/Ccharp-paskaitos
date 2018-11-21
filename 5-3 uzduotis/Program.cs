using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti kelis pažymius. 
            //Raskite šių pažymių vidurkį. 
            //Patikrinkite ar vidurkis teigiamas (daugiau arba lygu 5-iems), jei taip - išveskite “vidurkis teigiamas”. 

            Console.WriteLine("Iveskite penkis pazymius:");
            Console.Write("p1 = ");
            var p1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("p2 = ");
            var p2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("p3 = ");
            var p3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("p4 = ");
            var p4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("p5 = ");
            var p5 = Convert.ToInt32(Console.ReadLine());

            var vid = (p1 + p2 + p3 + p4 + p5) / 5;

            if (vid >=5)
            {
                Console.WriteLine("Jusu pazymiu vidurkis teigiamas");
            }
        }
    }
}
