using System;

class FromDecimalToHexadecimal
{
    static void Main()
    {
        int count = 0;
        int decimalNumber = int.Parse(Console.ReadLine());
        int n = (int)Math.Log(decimalNumber, 16) + 1;
        int[] array = new int[n];

        do
        {
            array[count] = decimalNumber % 16;
            decimalNumber = decimalNumber / 16;
            count++;
        } 
        while (decimalNumber != 0);

        Array.Reverse(array);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 10)
            {
                Console.Write("A");
            }
            else if (array[i] == 11)
            {
                Console.Write("B");
            }
            else if (array[i] == 12)
            {
                Console.Write("C");
            }
            else if (array[i] == 13)
            {
                Console.Write("D");
            }
            else if (array[i] == 14)
            {
                Console.Write("E");
            }
            else if (array[i] == 15)
            {
                Console.Write("F");
            }
            else
                Console.Write(array[i]);
        }
        Console.WriteLine();
    }
}

