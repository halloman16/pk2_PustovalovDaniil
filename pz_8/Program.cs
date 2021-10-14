using System;
using System.Collections.Generic;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] myArr = new int[10]; //массив
            Random rnd = new Random(10); // рандом

            for (int i = 0; i < myArr.Length; i++) // добавление элементов в массив
            {
                myArr[i] = rnd.Next(100);
                Console.WriteLine(myArr[i]);
            }
            Console.WriteLine();
            
            for (int i = 0; i < myArr.Length; i++) // нахождение индексов четных элементов
            {
                if (myArr[i] % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
            // вывод начинается с 0 элемента
        }
    }
}
