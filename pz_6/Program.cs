using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число: "); //запрашиваем число
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            int i = 1;

            while (i <= a)
            {
                b = b + i;
                i = i + 1;
            }           
            Console.WriteLine(b);
        }
    }
}
