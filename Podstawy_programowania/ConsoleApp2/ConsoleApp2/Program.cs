using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int liczba;

            Console.Write("Podaj liczbę całkowitą: ");
            str = Console.ReadLine();

            if (int.TryParse(str, out liczba) == false)
            {
                Console.WriteLine("Zły format liczby!");
            }
            else
            {
                Console.WriteLine("Liczba wynosi: {0}", liczba);
            }
            /*sprawdź czy dane podane z klawiatury są liczbą całkowitą dodatnią,
             * następnie sprawdź, czy liczba jest nieparzysta
             */
            Console.Clear();
            string str2;
            int liczba2;
            Console.WriteLine("\nPodaj liczbę całkowitą dodatnią: ");
            str2 = Console.ReadLine();

            if(int.TryParse(str2, out liczba2) == false)
            {
                Console.WriteLine("Zły format liczby!");
            }
            else
            {
                if (liczba2 > 0)
                {
                    Console.WriteLine("Liczba {0} jest dodatnia!", liczba2);
                }
                else
                {
                    Console.WriteLine("Liczba {0} nie jest dodatnia!", liczba2);
                }
                if (liczba2 % 2 == 0)
                {
                    Console.WriteLine("Liczba {0} jest parzysta!", liczba2);
                }
                else
                {
                    Console.WriteLine("Liczba {0} jest nieparzysta!", liczba2);
                }
            }
            byte age = 10;
            if (age == 18)
            {
                Console.WriteLine("Masz 18 lat.");
            }
            else if(age < 18)
            {
                Console.WriteLine("Masz mniej niż 18 lat");
            }
            else
            {
                Console.WriteLine("Masz więcej niż 18 lat");
            }

            //switch

            liczba = 11;
            switch (liczba)
            {
                case 5:
                    Console.WriteLine("Liczba = 5");
                    break;
                case 10:
                    Console.WriteLine("Liczba = 10");
                    break;
                case 15:
                    Console.WriteLine("Liczba = 15");
                    break;
                default:
                    Console.WriteLine("Liczba = {0}", liczba);
                    break;
            }
            Console.Clear();
            /*Użytkownik podaje z klawiatury
             * swoją narodowość
             * wykorzystaj switch do wyświetlenia pochodzenia
             * do wyboru uzytkownik ma 3 kraje: Polska, USA, Hiszpania
             * Uważaj na wielkość liter podanych przez użytkownika
             */
            string narodowosc;
            Console.WriteLine("Podaj narodowość: ");
            narodowosc = Console.ReadLine();

            switch (narodowosc.ToLower())
            {
                case "polska":
                    Console.WriteLine("Narodowość: {0}", narodowosc);
                    Console.WriteLine("Mówisz po polsku!");
                    break;
                case "usa":
                    Console.WriteLine("Narodowość: {0}", narodowosc);
                    Console.WriteLine("Mówisz po angielsku!");
                    break;
                case "hiszpania":
                    Console.WriteLine("Narodowość: {0}", narodowosc);
                    Console.WriteLine("Mówisz po hiszpańsku!");
                    break;
                default:
                    Console.WriteLine("Jesteś z innego kraju!");
                    break;
            }

            //pętle
            //wypisz liczby <1,10>
            int i;

            for(i=1;i < 11; i++)
            {
                Console.Write(i + " ");
            }

            /*napisz program, który wypisuje ulubione kolory
             * kolory przypisz do zminnej colors
             * użytkownik z klawiatury podaje ilość ulubionych kolorów
             * wykorzystaj pętle for do przypisania kolorów do zmiennej
             */
            Console.Clear();
            Console.WriteLine("Podaj ilość ulubionych kolorów");
            string color = "";
            string x;
            string count;
            count = Console.ReadLine();
            byte count1;
            if (byte.TryParse(count, out count1) == true)
            {
                for (i=0;i< count1; i++)
                {
                Console.WriteLine("Podaj kolor: ");
                x = Console.ReadLine();
                color = color + " " + x;
                }
                Console.WriteLine("Ulubione kolory: {0}", color);
            }
            else
            {
                Console.WriteLine("Niepoprawna Liczba!");
            }


            Console.ReadKey();
        }
    }
}
