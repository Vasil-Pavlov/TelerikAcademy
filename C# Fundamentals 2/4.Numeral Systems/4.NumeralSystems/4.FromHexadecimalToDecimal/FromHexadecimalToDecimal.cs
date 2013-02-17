using System;
using System.Linq;

class FromHexadecimalToDecimal
{
    static void Main()
    {
        string hexadecimalNumber = Console.ReadLine();
        int value = 0;
        int decimalNumber = 0;

        for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
        {
            if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "A")
            {
                value = 10;
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "B")
            {
                value = 11;
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "C")
            {
                value = 12;
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "D")
            {
                value = 13;
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "E")
            {
                value = 14;
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "F")
            {
                value = 15;
            }
            else
            {
                value = int.Parse((hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString()));
            }
                decimalNumber = decimalNumber + value * (int)(Math.Pow(16, i));
        }
        Console.WriteLine(decimalNumber);
    }
}


