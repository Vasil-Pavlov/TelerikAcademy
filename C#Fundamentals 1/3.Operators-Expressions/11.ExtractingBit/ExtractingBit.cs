using System;

class ExtractingBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int bitPosition = int.Parse(Console.ReadLine());
        int bitValue = (number >> bitPosition) & 1;

        Console.WriteLine("The bit value of number {0} at position {1} is {2}.",number,bitPosition,bitValue);

    }
}

