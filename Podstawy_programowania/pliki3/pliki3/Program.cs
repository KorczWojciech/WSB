using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pliki1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo wsbDir = new DirectoryInfo(",");
            DirectoryInfo studnetDir = new DirectoryInfo("C:\\users\\student");

            Console.WriteLine(studnetDir.FullName);
            Console.WriteLine(studnetDir.Name);
            Console.WriteLine(studnetDir.Parent);
            Console.WriteLine(studnetDir.Attributes);

            DirectoryInfo dataDir = new DirectoryInfo("C:\\users\\student\\C#files");
            string path = "C:\\users\\student\\C#files";

            string[] customers =
            {
                "Anna Kowalska",
                "Paweł Nowak",
                "Anna Kowal",
            };
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory("C:\\users\\student\\C#files");
                    string textfilePath = "C:\\users\\student\\C#files\\testfile1.txt";
                    File.WriteAllLines(textfilePath, customers);
                }
                else
                {
                    Console.WriteLine("Katalog został utworzony");
                    Console.WriteLine("Utworzenie katalogu: {0}", Directory.GetCreationTime(path));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }
            DirectoryInfo myDataDir = new DirectoryInfo(@path);
            FileInfo[] txtfiles = myDataDir.GetFiles("*.txt",SearchOption.AllDirectories);
            Console.WriteLine("Ilość plików: {0}", txtfiles.Length);
            foreach (FileInfo file in txtfiles)
            {
                Console.WriteLine("Nazwa {0}", file.Name);
                Console.WriteLine("Rozmiar {0}", file.Length);
            }


            if (Directory.Exists(path))
            {
                Console.WriteLine("Czy chcesz usunąć katalog? \n1 - TRUE\n0 - FALSE");
                string delete = Console.ReadLine();
                if (delete == "1")
                {
                    Directory.Delete(path, true);//true usuwa katalog z zawartością

                    if (!Directory.Exists(path))
                    {
                        Console.WriteLine("Katalog został usunięty!");
                        Console.WriteLine("Został usunięty katalog: {0}", Path.GetFileName(path));
                    }
                }
                else
                {
                    Console.WriteLine("Nie usunąłeś katalogu");
                }
            }

            Console.ReadKey();
        }
    }
}
