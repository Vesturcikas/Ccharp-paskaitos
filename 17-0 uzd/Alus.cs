using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_0_uzd
{
    class Alus
    {
        public int Laipsniai { get; private set; }
        public double Turis { get; private set; }
        public string Spalva { get; private set; }

        public Alus(int laipsniai, double turis, string spalva)
        {
            Laipsniai = laipsniai;
            Turis = turis;
            Spalva = spalva;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Laipsniai: " + Laipsniai);
            Console.WriteLine("Turis: " + Turis);
            Console.WriteLine("Spalva:" + Spalva);
            Console.WriteLine();
        }


    }



}
