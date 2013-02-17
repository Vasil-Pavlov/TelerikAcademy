using System;

class QuickSortAlgorithm
{
    public static void QuickSort(ref int[] array, int left, int right)
    {
        int leftIndex = left;
        int rightIndex = right;
        int pivot = array[(left + right) / 2];

        while (leftIndex <= rightIndex)
        {
            while (array[leftIndex].CompareTo(pivot) < 0)
            {
                leftIndex++;
            }
            while (array[rightIndex].CompareTo(pivot) > 0)
            {
                rightIndex--;
            }
            if (leftIndex <= rightIndex)
            {
                Swap(ref array[leftIndex++], ref array[rightIndex--]);
            }
        }

        if (rightIndex > left)
        {
            QuickSort(ref array, left, rightIndex);
        }
        if (leftIndex < right)
        {
            QuickSort(ref array, leftIndex, right);
        }
    }

    public static void Swap(ref int a, ref int b)
    {
        int exchanger = a;
        a = b;
        b = exchanger;
    }

    static void Main()
    {

        int[] arr = { 3, 4, 5, 6, 9, 10, 20, 30, -2, 4, 8 };

        QuickSort(ref arr, 0, arr.Length - 1);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write(arr[i] + "  ");
        }
        Console.WriteLine();
    }
}

