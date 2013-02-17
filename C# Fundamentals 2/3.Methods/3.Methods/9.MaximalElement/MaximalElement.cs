using System;

class Program
{
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++) Console.Write(array[i] + (i == array.Length - 1 ? "\n" : " "));
    }

    static void Swap(int[] array, int i, int j)
    {
        int t = array[i];
        array[i] = array[j];
        array[j] = t;
    }

    static int GetBestFromPosition(int[] array, int i, bool descending)
    {
        int best = i;

        for (int j = i + 1; j < array.Length; j++)
            if (descending ? array[j] < array[best] : array[best] < array[j])
                best = j;

        return best;
    }

    static void SelectionSort(int[] array, bool descending = false)
    {
        for (int i = 0; i < array.Length; i++)
            Swap(array, i, GetBestFromPosition(array, i, descending));
    }

    static void Main()
    {
        int[] array = { -1, -3, 4, -5, 6, -7 };

        SelectionSort(array);
        PrintArray(array);

        Console.WriteLine();
        SelectionSort(array, descending: true);
        PrintArray(array);
    }
}