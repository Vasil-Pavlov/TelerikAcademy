using System;

class MostFrequentNumber
{
    static void PrintTheMode(params int[] array)
    {
        int max = 0;
        int maxCount = 0;
        int current = 0;
        int currentCount = 1;

        for (int i = 0; i < array.Length; i++)
        {
            currentCount = 1;
            current = array[i];
            
            for (int j = i + 1; j < array.Length; j++)
            {

                if (current == array[j])
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
        Console.WriteLine("{0}==>{1} times",max,maxCount);
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
       PrintTheMode(arr);
    }
}

