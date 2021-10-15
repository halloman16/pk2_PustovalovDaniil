using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int stolb = 5; // кол-во столбцов
            int str = 5;  // кол-во строк
            int[,] a = new int[str, stolb];
            for (int i = 0; i < str; i++)
                for (int j = 0; j < stolb; j++)
                    // заполнение рандомными числами
                    a[i, j] = rnd.Next(100);
            int MinRow, Temp;
            for (int NumCol = 0; NumCol < 1; NumCol++) // ставим значение первой строки в порядке убывания
            {
                for (int NumRow = 0; NumRow < str; NumRow++)
                {
                    MinRow = NumRow;
                    for (int j = NumRow + 1; j < str; j++)
                        if (a[j, NumCol] > a[MinRow, NumCol])
                            MinRow = j;
                    Temp = a[NumRow, NumCol];
                    a[NumRow, NumCol] = a[MinRow, NumCol];
                    a[MinRow, NumCol] = Temp;
                }
            }
            // вывод массива
            for (int r = 0; r < stolb; r++)
            {
                for (int c = 0; c < str; c++)
                {
                    Console.Write("{0}\t", a[c, r]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();


        }
        
    }
}
