using System;

namespace pz_16
{
    class Program
    {
        static int Minmax(int x, int y, int z, int r)
        {
            int max;
            int min;
            
            if (x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
                                                                            //постепенная сортировка значений

            if (z > max)
            {
                max = z;               
            }
            else if (z < min)
            {
                min = z;
            }
           
            if (r > max)
            {
                max = r;
            }
            else if (r < min)
            {
                min = r;               
            }
            Console.WriteLine(min);
            return max;                       
        }


        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите c: ");                               //запрашиваем значения
            int c = int.Parse(Console.ReadLine());
            Console.Write("Введите d: ");
            int d = int.Parse(Console.ReadLine());

            int z = Minmax(a, b, c, d);
            Console.WriteLine(z);                       //вывод
        }
    }
}
