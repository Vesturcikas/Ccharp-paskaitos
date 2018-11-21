using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Paversime temperatura is Celcijaus laipsniu i Kelvino ir Fahrenheito laipsnius.");
            Console.Write("Iveskite temperatura Celcijaus laipsniais: ");
            var TempC = Convert.ToDouble(Console.ReadLine());
            var TempK = TempC + 273.15;
            var TempF = TempC * 1.8 + 32;
            Console.WriteLine("{0} Celcijaus laipsniu = {1} Kelvino laipsniu;", TempC, TempK);
            Console.WriteLine("{0} Celcijaus laipsniu = {1} Fahrenheito laipsniu;", TempC, TempF);

        }
    }
}
