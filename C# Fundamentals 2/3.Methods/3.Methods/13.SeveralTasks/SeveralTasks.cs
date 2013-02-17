using System;

class SeveralTasks
{
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + (i == arr.Length - 1 ? "\n" : " "));
    }

    static void Swap(int[] arr, int i, int j)
    {
        int t = arr[i];
        arr[i] = arr[j];
        arr[j] = t;
    }

    static int GetBestFromPosition(int[] arr, int i, bool descending)
    {
        int best = i;

        for (int j = i + 1; j < arr.Length; j++)
            if (descending ? arr[j] < arr[best] : arr[best] < arr[j])
                best = j;

        return best;
    }

    static void SelectionSort(int[] arr, bool descending = false)
    {
        for (int i = 0; i < arr.Length; i++)
            Swap(arr, i, GetBestFromPosition(arr, i, descending));
    }

    static void Main()
    {
        int[] arr = { -1, -3, 4, -5, 6, -7 };

        SelectionSort(arr);
        PrintArray(arr);

        Console.WriteLine();

        SelectionSort(arr, descending: true);
        PrintArray(arr);
    }
}