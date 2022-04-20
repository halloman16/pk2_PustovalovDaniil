using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_9_2semestr
{
    public delegate void Delegate();

    class Counter
    {
        public event Delegate onCount;
        public void Count()
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
            Console.WriteLine("Уведомление! Ограничение по визитам - 30!");
        }

        static void Main(string[] args)
        {
            Counter counter = new Counter();

            counter.onCount += Message;

            counter.Count();

        }
        
    }
}
