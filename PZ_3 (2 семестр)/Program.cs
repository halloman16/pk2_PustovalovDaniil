using System;

namespace PZ_3__2_семестр_
{
    class Program
    {
        static void Main(string[] args)
        {
            FractionalNumber fractionalNumber = new FractionalNumber(1, 1); //выводим различные варианты
            fractionalNumber.GetNumber();

            Console.WriteLine();

            FractionalNumber fractionalNumber1 = new FractionalNumber('+', 1, 1);
            fractionalNumber1.GetNumber();

            Console.WriteLine();

            FractionalNumber fractionalNumber2 = new FractionalNumber('-', 13, 15);
            fractionalNumber2.GetNumber();

            Console.WriteLine();

            FractionalNumber fractionalNumber3 = new FractionalNumber(30, 15);
            fractionalNumber3.GetNumber();
        }
    }

    public class FractionalNumber //создаем класс
    {
        public int divider; // создаем делитель, делимое и знак +/-
        public int dividend;
        public char sign;

        public FractionalNumber() { }         //создаем конструкторы
        public FractionalNumber(int dividend, int divider) { this.dividend = dividend; this.divider = divider; }
        public FractionalNumber(char sign, int dividend, int divider) { this.sign = sign; this.dividend = dividend; this.divider = divider; }

        public void GetNumber() //и метод вывода
        {
            Console.WriteLine($"Дробное число: {sign}{dividend}/{divider}");
        }             
    }
}
