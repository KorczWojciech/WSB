using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteki;
using Biblioteka_2;

namespace biblioteka_progam
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string a2, h;
            int x2, x3, x4;
            MathClass x = new MathClass();
            Class1 y = new Class1();
            Console.WriteLine("Podaj długość boku kwadratu: ");
            a=Console.ReadLine();
            Console.WriteLine("Podaj długość podstawy trójkąta i wysokość: ");
            a2 = Console.ReadLine();
            h = Console.ReadLine();
            x2 = int.Parse(a);
            x3 = int.Parse(a2);
            x4 = int.Parse(h);
            Console.WriteLine("Wynik dodawania to {0}",x.Add(5, 3));
            Console.WriteLine("Pole Kwadratu wynosi {0}",y.Kwadrat(x2));
            Console.WriteLine("Pole Trójkąta wynosi {0}",y.Trojkat(x3,x4));
            Console.ReadKey();

        }
    }
}
