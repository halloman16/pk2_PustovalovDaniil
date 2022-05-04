using System;

namespace PZ_11_2semestr
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            Console.Write("Введите строку, которую нужно развернуть: ");
            string text = Console.ReadLine();
            string texte = "";

            fixed (char* p = text) //фиксация указателя на 1 символе строки
            {
                int n = text.Length;
                char[] mas = new char[n];
                for (int i = 0; i < n; i++)
                {
                    mas[i] = text[i];
                }
                for (int i = n; i != 0; i--)
                {
                    texte += mas[i - 1];
                }
                Console.WriteLine(texte);
            }
        }
    }
}
