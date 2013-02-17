using System;

class ArrayComparison
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }

        int m = int.Parse(Console.ReadLine());
        int[] arr2 = new int[m];
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }
        bool equal = true;
        if (arr1.Length == arr2.Length)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    equal = false;
                    break;
                }
            }
        }
        else
        {
            equal = false;
        }
        Console.WriteLine(equal);
    }
}