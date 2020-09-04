using System;
using System.Collections.Generic;
namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> mixedList = new List<object>();
            int[] integers = { 7, 28, -1 };
            mixedList.Add(7);
            mixedList.Add(28);
            mixedList.Add(-1);
            mixedList.Add(true);
            mixedList.Add("chair");
            var sum = 0;
            for (var i = 0; i < mixedList.Count; i++)
            {
                Console.WriteLine(mixedList[i]);
                if (mixedList[i] is int)
                {
                    sum += (int)mixedList[i];
                }
            }
        Console.WriteLine(sum);
        }
    }
}