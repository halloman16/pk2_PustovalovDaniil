using System;

namespace pz_17
{
    class Program
    {
        static int[] Param(int[] nums)
        {
            int n = 0;          
            foreach (int i in nums)
            {
                if (i < 0)
                {                   
                    n++;        //проверяем значения температуры            
                }               
            }
            Console.WriteLine("Количество дней, когда температура была ниже 0*C: "+n);
            return nums; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количесво дней: ");
            int elements = int.Parse(Console.ReadLine());
            Console.WriteLine("Вводите значения температуры в эти дни: ");
            int[] myArr = new int[elements];            
            for (int i = 0; i < myArr.Length; i++) 
            {
                myArr[i] = int.Parse(Console.ReadLine()); //спрашиваем темературу
            }
            Param(myArr); 
        }
    }
}
