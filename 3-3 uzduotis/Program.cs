using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk1 = 2;
            var sk2 = 3;

            var suma = sk1 + sk2;
            var skirt = sk1 - sk2;

            Console.WriteLine("Suma: {0};\nSkirtumas: {1};\nSumos ir skirtumo sandauga: {2};\nSumos ir skirtumo dalmuo: {3}", 
                suma, skirt, suma*skirt, suma/skirt);
        }
    }
}
