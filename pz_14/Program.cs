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
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);

            
            var myFile = File.Create(@"C:\SomeDir\new\f2.txt");

            myFile.Close();

            File.AppendAllText(@"C:\SomeDir\new\f2.txt", File.ReadAllText(@"C:\SomeDir\f1.txt"));

        }
    }
}
