using System;

namespace _1_first_file
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
            Console.Write("Imię: "); //Wyświetla "Imię: "
            Console.WriteLine("Janusz");
            /*Komentarz w
             * wielu
             * liniach
             */
            Console.WriteLine("#\n##\n###\n####");

            string name;
            name = "Kasia";
            Console.WriteLine("Masz na imię: " + name); //+ konkatenacja

            Console.WriteLine("Masz na imię: {0}", name);

            int age = 20;
            Console.WriteLine("Masz na imię: {0}, Twój wiek to: {1}", name, age);

            sbyte age1 = 20;
            Console.WriteLine("Masz na imię: {0}, Twój wiek to: {1}", name, age1);

            /*Użytkownik podaje z klawiatury długość boku
             * Oblicz pole kwadratu
             */
            Console.Write("\nPodaj bok a: ");
            string a = Console.ReadLine();
            Console.WriteLine("Bok a wynosi: {0}", a);

            double result = double.Parse(a) * double.Parse(a);
            Console.WriteLine("Pole kwadratu wynosi: {0}", result);

            //Oblicz pole trójkąta, dane z klawiatury

            Console.Write("\nPodaj podstawe trójkąta: ");
            string a1 = Console.ReadLine();
            Console.Write("\nPodaj wysokość trójkąta: ");
            string h = Console.ReadLine();
            double result2 = double.Parse(a1) * double.Parse(h) / 2;
            Console.Write("Pole trójkąta wynosi: {0}\n", result2);

            uint x = 10;
            Console.WriteLine(x);

            float y = 14.55F;
            Console.WriteLine(y);


            Console.ReadKey();
        }
    }
}
