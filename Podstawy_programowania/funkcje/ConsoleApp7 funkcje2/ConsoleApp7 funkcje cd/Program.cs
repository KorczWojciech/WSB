using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_funkcje_cd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            increment(ref a);
            increment(ref a);
            increment(ref a);
            Console.ReadKey();
        }
        static void increment(ref int x)
        {
            x += 10;
            Console.WriteLine("Zmienna wewnątrz funkcji: {0}", x);
        }
    }
}
