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
            int a;
            increment(out a);
            increment(out a);
            increment(out a);
            Console.ReadKey();
        }
        static void increment(out int x)
        {
            x = 1;
            x += 10;
            Console.WriteLine("Zmienna wewnątrz funkcji: {0}", x);
        }
    }
}
