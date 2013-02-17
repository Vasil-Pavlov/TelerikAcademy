using System;

class BinarySearch
{
    static void Main()
    {
        int[] array = { 3, 4, 5, 6, 9, 10, 20, 30, -2, 4, 8 };
           
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i; j < array.GetLength(0); j++)
            {
                if (array[j] < array[i])
                {
                    int buf = array[i];
                    array[i] = array[j];
                    array[j] = buf;
                }
            }
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write(array[i] + "  ");
        }

        int min = 0;
        int max = array.GetLength(0) - 1;
        int mid;
        int x = 30;
        do
        {
            mid = (min + max) / 2;
            if (x > array[mid])
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }
        while (array[mid] != x && (min <= max));
        Console.WriteLine();
        Console.WriteLine("element {0} is equal to {1}", mid, x);
    }
}

