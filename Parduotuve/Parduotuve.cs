using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parduotuve
{
    class Parduotuve
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public string Vadovas { get; private set; }
        public List<Gerimas> Gerimai { get; private set; }

        public Parduotuve()
        {
            Console.Write("Iveskite pavadinima: ");
            Pavadinimas = Console.ReadLine();

            Console.Write("Iveskite adresa: ");
            Adresas = Console.ReadLine();

            Console.Write("iveskite kur yra gerimu failas: ");
            var failas = Console.ReadLine();

            var tekstas = File.ReadAllLines(failas);
            Gerimai = new List<Gerimas>();

            
            for (int i = 1; i < tekstas.Length; i++)
            {
                var gerimas = new Gerimas(tekstas[i]);
                Gerimai.Add(gerimas);
            }
        }

        public void Isvedimas()
        {
            Console.WriteLine("Parduotuve {0} randasi adresu {1}, jos vadovas {2}.", Pavadinimas, Adresas, Vadovas);
            Console.WriteLine("Turimi gerimai:");
            Console.WriteLine("|{0, -15}|{1, -15}|{2,-5}|{3,-5}|{4,-5}|", "Gamintojas", "Pavadinimas", "Laipsniai", "Tiekimo Kaina", "Turis");
            foreach (var gerimas in Gerimai)
            {
                gerimas.Isvedimas();
            }
            Console.WriteLine();

        }

    }
}
