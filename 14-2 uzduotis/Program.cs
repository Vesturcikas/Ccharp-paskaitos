using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurkite ir iškvieskite metodą, kuriame kintamuosiuose būtų saugoma informacija apie policininką
            //(vardas, pavardė, amžius, alga, etatas, specializacija). 
            //Išveskite šią informaciją suformatuotai (pavyzdžiui: įterpkite į sakinį, ar išveskite atskirose eilutėse ar pan.). 

            var inf = new Program();

            inf.informacija();


        }

        public void informacija()
        {
            var vardas = "Vesturas";
            var pavarde = "Stanevicius";
            var amzius = 42;
            var alga = 1000;
            var etatas = 1.0;
            var spec = "inzinierius";

            Console.Write("Musu imoneje dirba {5} {0} {1}, {2} metu, {4} etatu ir gauna {3} euru atlygima.", vardas, pavarde, amzius, alga, etatas, spec);
        }
    }
}
