using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_0_uzd
{
    class Lengva
    {
        public string Pamoka;
        public int Pazymys;
        public bool SuoloDraugas;

        //ctor -> tab
        public Lengva()
        {

        }


        public Lengva(string pamoka, int pazymys, bool suolodraugas)
        {
            Pamoka = pamoka;
            Pazymys = pazymys;
            SuoloDraugas = suolodraugas;

        }

        public void Nusirasyti()
        {
            if (SuoloDraugas==true)
            {
                Console.WriteLine();
            }
        }

        public void Isvedimas()
        {
            Console.WriteLine("Pamoka: " +Pamoka);
            Console.WriteLine("Pazymys: " + Pazymys);
            Console.WriteLine("Suolo draugas: " + SuoloDraugas);
            Console.WriteLine();
        }

    } 





    class Program
    {
        static void Main(string[] args)
        {
            Lengva objektas = new Lengva();
            var objektas1 = new Lengva();

            objektas.Pamoka = "Fizika";
            objektas.Pazymys = 9;
            objektas.SuoloDraugas = false;

            objektas1.Pamoka = "Matematika";
            objektas1.Pazymys = 5;
            objektas1.SuoloDraugas = true;

            Console.WriteLine("Objektas: ");
            objektas.Isvedimas();
            objektas.Nusirasyti();

            Console.WriteLine("Objektas1: ");
            objektas1.Isvedimas();
            objektas1.Nusirasyti();

            var objektas3 = new Lengva("Biologija", 8, true);

            Console.WriteLine("Objektas3: ");
            objektas3.Isvedimas();
            objektas3.Nusirasyti();

            var gerimas = new Alus(5, 0.5, "Sviesus");

            gerimas.Isvedimas();

        }
    }
}
