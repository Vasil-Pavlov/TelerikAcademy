

using System;

class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int exchanger = 0;
                    exchanger = array[i];
                    array[i] = array[j];
                    array[j] = exchanger;
                }
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0}", array[i]);
            if (i>=0 && i<array.Length-1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}