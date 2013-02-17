using System;
using System.Linq;

class FromDecimalToBinary
{
    static void Main()
    {
        int count = 0;
        int decimalNumber = int.Parse(Console.ReadLine()); 
        int n = (int)Math.Log(decimalNumber, 2) + 1;
        int[] array = new int[n];

        do
        {
            array[count] = decimalNumber % 2;
            decimalNumber = decimalNumber / 2;
            count++;
        } 
        while (decimalNumber != 0);

        Array.Reverse(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
}

