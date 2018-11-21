using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_14_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite bet koki simboli: ");
            var simb = Console.ReadLine();
            Console.WriteLine("  {0}", simb);
            Console.WriteLine(" {0}{0}{0}", simb);
            Console.WriteLine("{0}{0}{0}{0}{0}", simb);
            Console.WriteLine("  {0}", simb);
            Console.WriteLine(" {0}{0}{0}", simb);
            Console.WriteLine("{0}{0}{0}{0}{0}", simb);
            Console.WriteLine("  {0}", simb);
            Console.WriteLine(" {0}{0}{0}", simb);
            Console.WriteLine("{0}{0}{0}{0}{0}", simb);
        }
    }
}
