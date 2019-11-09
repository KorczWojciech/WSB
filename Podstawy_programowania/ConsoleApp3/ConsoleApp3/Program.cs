using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tab = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int count = 3;
            //console.writeline("indeks: {1}, element tablicy: {0}", tab[3], count);
            //for (int i = 0; i < tab.length; i++)
            //{
            //    console.write("{0} ", tab[i]);
            //}
            //console.writeline();
            //foreach (int item in tab)
            //{
            //    console.write("{0} ", item);
            //}
            //console.readkey();
            //console.clear();
            //int j = 1;
            //foreach (int item in tab)
            //{
            //    console.writeline("element {0}: {1}", j, item);
            //    j++;
            //}
            //console.readkey();
            //console.clear();
            ///*użytkownik podaje z klawiatury 3 swoje ulubione kolory, przypisz je do tablicy i wyśiwtl na ekranie
            // * w formacie
            // * kolor 1: ...
            // * kolor 2: ...
            // * do przypisania kolorów wykorzystaj pętle for, a do wypisania pętle while
            // */
            //string[] kolor = new string[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    console.writeline("podaj {0}. kolor", i + 1);
            //    kolor[i] = console.readline();


            //}
            //uint k = 0;
            //while (k < kolor.length)
            //{
            //    console.writeline("kolor {0}: {1}", k + 1, kolor[k]);
            //    k++;
            //}
            //console.readkey();
            //console.clear();
            //tablica prostokątna
            //int[,] tab1 = new int[,]
            //{
            //    {1, 2, 3, 4},
            //    {5, 6, 7, 8},
            //    {9, 10, 11, 12},
            //    {13, 14, 15, 16}
            //};

            //for (int i = 0; i < tab1.GetLength(0); i++)
            //{
            //    for (int l = 0; l < tab1.GetLength(1); l++)
            //    {
            //        Console.Write("{0} \t", tab1[i, l]);
            //    }
            //    Console.WriteLine();
            //}


            ////TABLICA WIELOWYMIAROWA********************************************************************************************
            //************************************************************************************************************************************************************

            //int[][] number = new int[4][]
            //{
            //    new int[]  {1,2},
            //    new int[]  {3,4,5},
            //    new int[]  {6},
            //    new int[]  {7,8,9,10},
            //};

            //for (int i = 0; i < number.Length; i++)
            //{
            //    for (int j = 0; j < number[i].Length; j++)
            //    {
            //        Console.Write("{0} \t", number[i][j]);
            //    }
            //    Console.WriteLine();
            //}
            //foreach (int[] item in number[0])
            //{
            //    foreach (int[] item in number[1])
            //    {
            //        Console.Write("{0} \t", item);
            //    }

            //}

            //UPROSZCZONE WYRAŻENIA INICJALIZACJI********************************************************************************************

            //char[] vowels = { 'a', 'e', 'i' };
            //Console.WriteLine(vowels[2]);

            //int[,] age =
            //{
            //    {10,20 },
            //    {30,40 },
            //    {50,60 }
            //};
            //Console.WriteLine( age[1,1]);

            //string[][] name =
            //{
            //    new string[] {"Anna"},
            //    new string[] {"Anna", "Nowak"},
            //    new string[] {"Anna"}
            //};
            //Console.WriteLine(name[1][1]);

            //Console.WriteLine("Ilość wymiarów: {0}", vowels.Rank); //1
            //Console.WriteLine("Ilość wymiarów: {0}", age.Rank); //2
            //Console.WriteLine("Ilość wymiarów: {0}", name.Rank); //1
            //Console.WriteLine("Ilość wymiarów: {0}", name[1].Rank); //1

            //KOPIOWANIE TABLIC********************************************************************************************

            //int[] tab = { 1, 2, 3, 4, 5 };
            //int[] tabCopy = new int[7];

            //foreach (int item in tabCopy)
            //{
            //    Console.Write("{0} ",item);
            //};
            //Console.WriteLine();
            //tab.CopyTo(tabCopy, 0);
            //foreach (int item in tabCopy)
            //{
            //    Console.Write("{0} ", item);
            //};
            //Console.WriteLine();
            //Array.Copy(tab, tabCopy, tab.Length);
            //foreach (int item in tabCopy)
            //{
            //    Console.Write("{0} ", item);
            //};

            //MODYFIKATORY KONSOLI********************************************************************************************

            //Console.Title = "Modyfikacja nazwy konsoli";
            //Console.WriteLine("WSB");
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("WSB");
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.WriteLine("WSB");
            //Console.ResetColor();
            //Console.WriteLine("WSB");

            //TYPY WARTOŚCIOWE I REFERENCYJNE********************************************************************************************

            //typ wartościowy
            //int a = 10;
            //int b = a;
            //a--;
            //Console.WriteLine(a);//9
            //b++;
            //Console.WriteLine(b);//11

            ////typy referencyjne

            //int[] tabA = { 1, 2, 3};
            //int[] tabB = tabA;

            //tabA[1] = 100;
            //tabB[tabB.Length - 1] = 200;

            //Console.WriteLine("TabA");
            //foreach (int item in tabA)
            //{
            //    Console.Write("{0} ",item);                 //1,100,200
            //}
            //Console.WriteLine("\nTabB");
            //foreach (int item in tabB)
            //{
            //    Console.Write("{0} ", item);                //1,100,200
            //}

            ////***************************************************************************************************************************************

            //Console.WriteLine("\nTab3");

            //int[] tab3 = {1,2,3 };
            //int[] tab4 = new int[3];

            //tab3.CopyTo(tab4, 0);

            //tab4[2] = 1000;

            //foreach (int item in tab3)
            //{
            //    Console.Write("{0} ", item);                //1,2,3
            //}
            //Console.WriteLine("\nTab4");
            //foreach (int item in tab4)
            //{
            //    Console.Write("{0} ", item);                //1,2,1000
            //}

            //WYJĄTKI**************************************************************************************************************************
            //*********************************************************************************************************************************

            //Console.WriteLine("Wprowadź liczbę całkowitą:");
            //string x = Console.ReadLine();

            //try
            //{
            //    uint number = uint.Parse(x);
            //}
            //catch (SystemException e)
            //{
            //    Console.WriteLine("Error: {0}", e.Message);
            //};
            string x;
            uint number;
            while (true)
            {
                Console.WriteLine("Wprowadź liczbę całkowitą:");

                try
                {
                    x = Console.ReadLine();
                    number = uint.Parse(x);
                    break;
                }
                catch (SystemException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: {0}", e.Message);
                    Console.ResetColor();
                };

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Prawidłowe dane: {0}",number);


            Console.ReadKey();
        }
    }
}
