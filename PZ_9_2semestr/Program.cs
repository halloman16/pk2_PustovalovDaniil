using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_9_2semestr
{
    public delegate void Delegate(); //создаем делегат

    class Counter
    {
        public event Delegate onCount; // создаем событие
        public void Count() // делаем добавление объектов в класс через цикл
        {
            for (int i = 0; i < 35; i++)
            {
                Console.WriteLine(i);
                if (i == 30)
                {
                    onCount();
                    break;
                }
            }
            Console.ReadLine();
        }
    }

    public static class Program
    {

        public static void Message()
        {
            Console.WriteLine("Уведомление! Ограничение по визитам - 30!"); // содержание события
        }

        static void Main(string[] args)
        {
            Counter counter = new Counter(); 

            counter.onCount += Message;// назначаем содержание для события

            counter.Count(); //выполняем код

        }
        
    }
}
