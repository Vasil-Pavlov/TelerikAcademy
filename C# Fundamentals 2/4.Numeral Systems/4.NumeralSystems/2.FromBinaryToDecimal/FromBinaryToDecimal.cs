using System;
using System.Linq;

class FromBinaryToDecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();

        int decimalNumber = 0;
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            int currentBitValue = int.Parse((binaryNumber.ElementAt(binaryNumber.Length - 1 - i).ToString()));
            decimalNumber = decimalNumber + currentBitValue * (int)(Math.Pow(2, i));
        }
        Console.WriteLine(decimalNumber);
    }
}

