using System;
using System.IO;
using System.Threading;

namespace pz_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // спрашиваем слово
                       
            string[] mas = File.ReadAllLines(@"C:\SomeDir\f1.txt");           
            foreach (string a in mas) // ищем слово в строчках
            {
                if (a.Contains(s))
                {
                    Console.WriteLine(a); // выводим слово                   
                }
            }                       
        }
    }
}
