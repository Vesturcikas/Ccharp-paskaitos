using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parduotuve
{
    class Gerimas
    {
        public string Gamintojas { get; private set; }
        public string Pavadinimas { get; private set; }
        public double Laipsniai { get; private set; }
        public double TiekimoKaina { get; private set; }
        public double Turis { get; private set; }

        public Gerimas(string eilute)
        {
            var isskaidyti = eilute.Split(';');
            Gamintojas = isskaidyti[0];
            Pavadinimas = isskaidyti[1];
            Laipsniai = Convert.ToDouble(isskaidyti[2]);
            TiekimoKaina = Convert.ToDouble(isskaidyti[3]);
            Turis = Convert.ToDouble(isskaidyti[4]);
        }

        public void Isvedimas()
        {
            Console.WriteLine("|{0, -15}|{1, -15}|{2,-5}|{3,-5}|{4,-5}|", Gamintojas, Pavadinimas, Laipsniai, TiekimoKaina, Turis);
        }

    }
}
