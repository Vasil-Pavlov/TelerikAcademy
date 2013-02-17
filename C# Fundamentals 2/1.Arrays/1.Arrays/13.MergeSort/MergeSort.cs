using System;

class Program
{
    public static void Sort(int[] data, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            Sort(data, left, middle);
            Sort(data, middle + 1, right);
            Merge(data, left, middle, middle + 1, right);
        }
    }

    public static void Merge(int[] unsortedArray, int left, int middle, int middle1, int right)
    {
        int oldPosition = left;
        int size = right - left + 1;
        int[] mergedArray = new int[size];
        int currentElement = 0;

        while ((left <= middle) && (middle1 <= right))
        {
            if (unsortedArray[left] <= unsortedArray[middle1])
            {
                mergedArray[currentElement++] = unsortedArray[left++];
            }
            else
            {
                mergedArray[currentElement++] = unsortedArray[middle1++];
            }
        }
        if (left > middle)
        {
            for (int j = middle1; j <= right; j++)
            {
                mergedArray[currentElement++] = unsortedArray[middle1++];
            }
        }
        else
        {
            for (int j = left; j <= middle; j++)
            {
                mergedArray[currentElement++] = unsortedArray[left++];
            }
        }
        Array.Copy(mergedArray, 0, unsortedArray, oldPosition, size);
    }

    static void Main()
    {
        int[] arr = { 3, 4, 5, 6, 9, 10, 20, 30, -2, 4, 8 };
       
        Sort(arr, 0, arr.Length - 1);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write(arr[i] + "  ");
        }
        Console.WriteLine();
    }
}

