using System;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            string str;

            while (true)
            {
                Console.ResetColor();
                Console.WriteLine("Podaj liczbe całkowitą: ");
                str = Console.ReadLine();
                try
                {
                    number = uint.Parse(str);
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wprowadż liczbę w prawidłowym formacie!");
                  
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wprowadzona liczba jest poza dopuszczalnym zakresem!");
                }
                catch (ArgumentNullException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wartość nie może być pusta!");
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error {0}", e.Message);
                }

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Liczba całkowita: {0}", number);
            Console.ReadKey();
        }
    }
}
