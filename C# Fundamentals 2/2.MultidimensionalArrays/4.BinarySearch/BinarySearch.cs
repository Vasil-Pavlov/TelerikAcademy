using System;

class BinarySearch
{
    static void Main()
    {
        int n = 4;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int k = 5;
        int far = Array.BinarySearch(arr, k);
        if (far >= 0)
        {
            Console.WriteLine("We have that number at position {0}", far);
        }
        else if (far == -1)
        {
            Console.WriteLine("We don't have number <= k");
        }
        else if (Math.Abs(far) > n)
        {
            Console.WriteLine(arr[n - 1]);
        }
        else
        {
            Console.WriteLine(arr[Math.Abs(far) - 2]);
        }
    }
}

