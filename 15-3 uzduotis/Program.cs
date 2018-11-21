using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurkite 4 skirtingus metodus sumos, skirtumo, sandaugos bei dalmens radimui. 
            //Kiekvienas iš jų turi priimti po du sveikuosius skaičius, turi išvesti kokį veiksmą ir su kokiais skaičiais atliko, 
            //bei atsakymą (pvz.: 5 + 7 = 12). 
            //Iškvieskite šiuos metodus bent po vieną kartą, duodant skirtingus arba tuos pačius skaičius. 

            var veik = new Program();

            int a;
            int b;

            Console.WriteLine("Iveskite skaicius a ir b , su kuriais bus atliekami paprasti aritmetiniai veiksmai.");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            veik.aritmetika(a, b);

        }

        public void aritmetika(int a, int b)
        {
            suma(a, b);
            skirtumas(a, b);
            sandauga(a, b);
            dalyba(a, b);
        }

        public void suma(int a, int b)
        {
            int suma = a+b;
            Console.WriteLine("{0} + {1} = {2}", a, b, suma);
            Console.WriteLine();
        }

        public void skirtumas(int a, int b)
        {
            int skirt = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, skirt);
            Console.WriteLine();
        }

        public void sandauga(int a, int b)
        {
            int sand = a * b;
            Console.WriteLine("{0} * {1} = {2}", a, b, sand);
            Console.WriteLine();
        }

        public void dalyba(int a, int b)
        {
            int dalyb = a / b;
            Console.WriteLine("{0} / {1} = {2}", a, b, dalyb);
            Console.WriteLine();
        }


    }
}
