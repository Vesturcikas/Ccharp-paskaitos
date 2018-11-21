using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_papild1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa skirta apskaiciuoti cilindro pavirsiaus plota ir turi, pagal vartotojo uzduota cilindro radiusa ir cilindro auksti

            Console.WriteLine("Cilindro ploto ir turio apskaiciavimas.");
            Console.Write("Iveskite cilindro radiusa R(m): ");

            double R = Convert.ToDouble(Console.ReadLine());

            Console.Write("Iveskite cilindro auksti h(m): ");

            double h = Convert.ToDouble(Console.ReadLine());

            double SPA = 2 * 3.14 * R*(R + h);
            double Vcil = 3.14 * Math.Pow(R, 2) * h;

            Console.WriteLine("Cilindro pavirsiaus plotas: " + SPA + " m2.");
            Console.WriteLine("Cilindro turis: " + Vcil + " m3.");


        }
    }
}
