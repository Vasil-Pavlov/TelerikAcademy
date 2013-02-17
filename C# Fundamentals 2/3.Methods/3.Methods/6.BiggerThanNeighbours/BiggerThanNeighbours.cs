using System;

class BiggerThanNeigbours
{
    static bool IsInside(int[] array, int i)
    {
        return 0 <= i && i < array.Length;
    }

    static bool IsBigger(int[] array, int i, int j)
    {
        return IsInside(array, j) ? array[i] > array[j] : true;
    }

    static bool IsBiggerThanNeighbours(int[] array, int i)
    {
        return IsBigger(array, i, i - 1) && IsBigger(array, i, i + 1);
    }

    static int GetElementBiggerThanNeighbours(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (IsBiggerThanNeighbours(array, i))
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] array = { 1, 2, 2, 3, 2 };

        Console.WriteLine(GetElementBiggerThanNeighbours(array));
    }
}