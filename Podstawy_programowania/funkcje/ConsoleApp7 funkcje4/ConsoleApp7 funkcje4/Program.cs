using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_funkcje4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 10;
            Console.WriteLine("Wartość tablicy przed wywyołaniem funkcji {0} {1}", tab[0], tab[1]);
            Tab(tab);
            Console.ReadKey();
        }
        static void Tab(int[] tab)
        {
            tab[0] = 50;
            tab[1] = 100;
            Console.WriteLine("Wartość wewnątrz funkcji : {0} {1}",tab[0],tab[1]);
        }
    }
}
