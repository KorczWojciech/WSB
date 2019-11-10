using System;

namespace ConsoleApp7_wyjątki3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Utwórz tablice, użytkownik podaje rozmiar tablicy
             * użytkownik podaje wiek swojej rodziny - każda osoba
             * przypisz wiek osób do tablicy 
             * wyświetl tablicę użytkownikowi
             * a następni zadaj pytanie jaki jest ostatni indeks tablicy
             * wyświetl ten element na ekranie w formacie:
             * ostatnie element tavlicy:
             * wyświetl równiez średni wiek wszystkich osób z rodziny
             * zabezpiecz program przed mozliwymi wyjątkami
             */
            uint index;
            string x;
            while (true)
            {
                Console.WriteLine("Podaj ilość osób w twojej rodzinie: ");

                try
                {
                    index = Console.ReadLine();
                    index = uint.Parse(x);
                    break;
                }
                catch (SystemException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: {0}", e.Message);
                    Console.ResetColor();
                };

            }



            Console.ReadKey();

        }
    }
}
