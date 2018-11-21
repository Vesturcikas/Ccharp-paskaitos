using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parašykite ir iškvieskite metodą, kuris per argumentų sąrašą priimtų norimą žodį. 
            //Metodas gautą žodį turi išvesti jį apskliaudžiant dviem brūkšniukais iš kiekvieno šono (pavyzdžiui: -- pomidoras --). 
            //Šį metodą kvieskite 5 kartus, kiekvieną kartą metodui duodant vis kitokį žodį. 

            var gel = new Program();
            var zodis="nieko";

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Iveskite norima zodi: ");
                zodis = Console.ReadLine();
                gel.bruksneliai(zodis);
            }
            
        }

        public void bruksneliai (string zod)
        {
            Console.WriteLine("--" + zod + "--");
            Console.WriteLine();
        }

    }
}
