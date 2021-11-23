using System;
using System.IO;

namespace pz_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\SomeDir"; 
            string subpath = @"new";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists) // создание папки SomeDir
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath); // создание папки new

            
            var myFile = File.Create(@"C:\SomeDir\new\f2.txt"); // создание файла f2 

            myFile.Close();

            File.AppendAllText(@"C:\SomeDir\new\f2.txt", File.ReadAllText(@"C:\SomeDir\f1.txt")); // копирование инфы из f1 в f2

        }
    }
}
