using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_funkcje
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 10;
            int d = 20;
            add(c, d);
            Console.WriteLine("Wynik dodawania to: {0}",add(c, d, 4));
            Console.WriteLine("Wynik dodawania to: {0}",add(1,2,d:3));
            data("Jan");
            parzysta(4);
            Console.WriteLine("Suma = {0}",sum(338));
            Console.ReadKey();
        }
        static void add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Wynik dodawania: {0}", result);
        }
        static int add(int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }
        static int add(int a, int c, int d,int b=10)
        {
            int result = a+b+c+d;
            return result;
        }
        static void data (string name, string surname="Nowak", int age=30)
        {
            Console.WriteLine("Imię : {0} \nNazwisko: {1} \nWiek: {2}", name,surname,age);
        }
        static void parzysta(int num)
        {
            if (num%2==0)
                Console.WriteLine("Liczba jest parzysta");
            else
                Console.WriteLine("Liczba jest nieparzysta");
        }
        static int sum(int num2)
        {
            int suma=0;
            while (num2>0)
            {
                suma = suma + num2 % 10;
                num2 = num2 / 10;
            }
            return suma;
        }
    }
}
