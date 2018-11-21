using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk = 5;
             
            Console.WriteLine("Skaiciaus :{0}, kvadratas = {1}, o 3 laipsniu - {2}", sk, Math.Pow(sk, 2), Math.Pow(sk, 3));
        }
    }
}
