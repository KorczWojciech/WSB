using System;
using second_name;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WSB");

            first_name.namespace_1 ob = new first_name.namespace_1();
            ob.method();

            namespace_2.method();

            Outer.Middle.Inner.Prog ob3 = new Outer.Middle.Inner.Prog();
            Console.WriteLine("Suma Wynosi: {0}", ob3.Add(3,6));

            Console.ReadKey();
        }
    }
}
namespace first_name
{
    class namespace_1
    {
        public void method()
        {
            Console.WriteLine("Pierwsza przestrzeń nazw");
        }
    }
}
namespace second_name
{
    static class namespace_2
    {
        public static void method()
        {
            Console.WriteLine("Druga przestrzeń nazw");
        }
    }
}
namespace Outer
{
    namespace Middle
    {
        namespace Inner
        {
            class Prog
            {
                public int x, y;

                public int Add(int x, int y)
                {
                    return x + y;
                }
            }
        }
    }
}