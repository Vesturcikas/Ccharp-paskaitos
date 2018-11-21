using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Susikurkite skaičių masyvą. Atspausdinkite pirmą, antrą ir paskutinį skaičius iš šio masyvo. 

            var skaiciai = new[] { 15, 62, 98, 46, 87 };

            Console.WriteLine("Masyvo { 15, 62, 98, 46, 87 } pirmas narys: " + skaiciai[0]);
            Console.WriteLine("Masyvo { 15, 62, 98, 46, 87 } antras narys: " + skaiciai[1]);
            Console.WriteLine("Masyvo { 15, 62, 98, 46, 87 } antras narys: " + skaiciai[4]);



        }
    }
}
