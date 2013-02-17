using System;

class AdjacentElements
{
    static void CompareArrayElements(params int[] array)
    {
        int currentValue;
        for (int i = 1; i < array.Length; i++)
        {
            currentValue = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] > currentValue)
                {
                    Console.WriteLine("Array[{0}]>Array[{1}]", j, i);
                }
                else if (array[j] < currentValue)
                {

                    Console.WriteLine("Array[{0}]<Array[{1}]", j, i);
                }
                else
                {
                    Console.WriteLine("Array[{0}]=Array[{1}]", j, i);
                }
            }

            for (int j = i - 1; j <= i; j++)
            {
                if (array[j] < currentValue)
                {

                    Console.WriteLine("Array[{0}]<Array[{1}]", j, i);
                }
                else if (array[j] > currentValue)
                {

                    Console.WriteLine("Array[{0}]>Array[{1}]", j, i);
                }
                else
                {
                    Console.WriteLine("Array[{0}]=Array[{1}]", j, i);
                }
            }
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //int[] arr = { 5, 4, 3, 2, 1 };
        int[] arr = new int[n];
        for (int i = 0; i <arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        CompareArrayElements(arr);
    }
}

