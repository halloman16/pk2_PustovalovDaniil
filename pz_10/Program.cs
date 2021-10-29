using System;
using System.Linq;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] myArr = new string[11][]; // создаем массив
            myArr[0] = new string[] { "a","b","c","d","e","f","g","h","i","j"}; // даем массиву значения
            myArr[1] = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k" };
            myArr[2] = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i" };
            myArr[3] = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "l" };
            myArr[4] = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "fg", "ergr" };
            myArr[5] = new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };
            myArr[6] = new string[] { "a", "b", "c", "d", "e" };
            myArr[7] = new string[] { "a", "b", "sdd", "d", "ghfh", "f", "htjtjtj", "h", "i", "j" };
            myArr[8] = new string[] { "afghf", "b", "gjfh", "bltk", "e", "knntk", "g", "h", "i", "j" };
            myArr[9] = new string[] { "a", "b", "c" };
            myArr[10] = new string[] { "a", "b", "c", "h", "i", "j" };

            for (int i = 0; i < myArr.Length; i++) // вывод массива
            {
                for (int j = 0; j < myArr[i].Length; j++)
                {
                    Console.Write($"{myArr[i][j]} \t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i != 10; i++) // я попытался сделать вывод последних элементов, но вывод неправильный
                myArr[i][0] = myArr[i][^1];
            Console.WriteLine("last: ");
            for (int i = 0; i != 10; i++)
                Console.Write($"{myArr[i]} ");
            Console.WriteLine("\n");            
        }
    }
}
