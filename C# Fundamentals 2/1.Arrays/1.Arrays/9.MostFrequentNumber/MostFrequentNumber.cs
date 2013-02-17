using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int maxCount = 0;
            int current = 0;
            int currentCount = 1;
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                currentCount = 1;
                current = arr[i];
                for (int j = i + 1; j < n; j++)
                {

                    if (current == arr[j])
                    {
                        currentCount++;
                    }
                }
                if (maxCount < currentCount)
                {
                    max = current;
                    maxCount = currentCount;
                }
            }
            Console.WriteLine("Number {0}({1}times)", max, maxCount);
        }
    }
}
