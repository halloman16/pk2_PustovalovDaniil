using System;
using System.Collections.Generic;

namespace pz_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "у Вани было 11 яблок, а у Оли 12";
            var words = data.Split();
            int i;
            int n = 0;
            List<int> integers = new List<int>();
            foreach (var s in words)
            {
                if (int.TryParse(s, out i)) { integers.Add(i); }
                n += i;
            }
            Console.WriteLine(n);
        }
    }
}
