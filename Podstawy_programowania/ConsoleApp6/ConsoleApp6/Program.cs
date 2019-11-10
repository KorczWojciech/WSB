using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = 10;
            try
            {
                Console.WriteLine("Podaj dzień tygodnia (1-5)");
                string str = Console.ReadLine();
                x = uint.Parse(str);
            }
            catch 
            {
                Console.WriteLine("Error");
                
            }
            finally
            {
                Console.WriteLine("x = {0}",x);
            }
            switch (x)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Sroda");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    throw new Exception("Masz już weekend, sobota");
                case 7:
                    throw new Exception("Masz już weekend, niedziela");
                default:
                    throw new ArgumentOutOfRangeException("Liczba poza zakresem!");
            }

            Console.ReadKey();
        }
    }
}
