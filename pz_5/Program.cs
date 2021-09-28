using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            int a;
            Console.WriteLine("Задание 1 (22 вариант)");
            for (a = 20; a <= 80; a += 3)
            {
                Console.WriteLine(a);
            }



            //задание 2
            Console.WriteLine("Задание 2 (22 вариант)");
            char simvol = 'з';
            Console.Write(simvol);
            simvol++;
            Console.Write(simvol);
            simvol++;
            Console.Write(simvol);
            simvol++;
            Console.Write(simvol);
            simvol++;
            Console.Write(simvol);
            simvol++;
            Console.WriteLine(simvol);



            //задание 3
            Console.WriteLine("Задание 3 (22 вариант)");
            string b = "######";
            int m;
            for (m = 1; m < 9; m++)
            {
                Console.WriteLine(b);
            }



            //задание 4
            Console.WriteLine("Задание 4 (22 вариант)");
            int v;
            for (v = 1; v <= 100; v++)
            {
                if (v % 19 == 0)
                {
                    Console.WriteLine(v);
                }
            }



            //задание 5
            Console.WriteLine("Задание 5 (22 вариант)");
            int i = 0;
            int j = 99;
            while (j - i != 21)
            {
                i++;
                j--;
                Console.WriteLine("i = " + i + ", j = " + j);
            }
        }
    }
}
