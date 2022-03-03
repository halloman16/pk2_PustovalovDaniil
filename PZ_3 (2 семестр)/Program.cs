using System;

namespace PZ_3__2_семестр_
{

    
    
    class Program
    {
        static void Main(string[] args)
        {
            

            FractionalNumber fractionalNumber = new FractionalNumber('+', 1, 0); //выводим различные варианты
            fractionalNumber.GetNumber();

            Console.WriteLine();

            FractionalNumber fractionalNumber1 = new FractionalNumber('+', 1, 1);
            fractionalNumber1.GetNumber();

            Console.WriteLine();

            FractionalNumber fractionalNumber2 = new FractionalNumber('-', 13, 15);
            fractionalNumber2.GetNumber();

            Console.WriteLine();

            FractionalNumber fractionalNumber3 = new FractionalNumber('-', 30, 0);
            fractionalNumber3.GetNumber();
            




        }

    }
    
}
