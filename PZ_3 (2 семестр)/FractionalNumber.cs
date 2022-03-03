using System;
using System.Collections.Generic;
using System.Text;

namespace PZ_3__2_семестр_
{
    class FractionalNumber //создаем класс
    {
        private int divider;                                             // создаем делитель, делимое и знак +/-
        public int dividend;
        public char sign;
        int s;
        int b;





       // public FractionalNumber() { }         //создаем конструкторы
       // public FractionalNumber(int dividend, int Divider) { this.dividend = dividend; this.Divider = divider; }
        public FractionalNumber(char sign, int dividend, int divider) { this.sign = sign; this.dividend = dividend; this.divider = divider; }
        public int Divider
        {
            get { return divider; }
            set
            {
                if (divider == 0)
                {
                    Console.WriteLine("Недопустимое выражение!");
                }
                else divider = value;

            }
        }
        public char Counter
        {
            get { return sign; }
            set
            {
                if (sign == '+')
                {
                    s++;
                }
            }
        }
        public char Couuuunter
        {
            get { return sign; }
            set
            {
                if (sign == '-')
                {
                    b++;
                }
            }
        }




        public void GetNumber() //и метод вывода
        {
            Console.WriteLine($"Дробное число: {sign}{dividend}/{divider}");
            Console.WriteLine($"Положительные числа кол-во: {s}");
            Console.WriteLine($"Отрицательные числа кол-во: {b}");
        }

    }
}
