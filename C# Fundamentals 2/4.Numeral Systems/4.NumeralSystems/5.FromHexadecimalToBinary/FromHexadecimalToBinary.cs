using System;
using System.Linq;

class FromHexadecimalToBinary
{
    static void Main()
    {
        string hexadecimalNumber = Console.ReadLine();
        string binaryNumber = "";
        string currentValue = "";

        for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
        {
            if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "A")
            {
                currentValue = "1010";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "B")
            {
                currentValue = "1011";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "C")
            {
                currentValue = "1100";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "D")
            {
                currentValue = "1101";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "E")
            {
                currentValue = "1110";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "F")
            {
                currentValue = "1111";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "9")
            {
                currentValue = "1001";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "8")
            {
                currentValue = "1000";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "7")
            {
                currentValue = "0111";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "6")
            {
                currentValue = "0110";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "5")
            {
                currentValue = "0101";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "4")
            {
                currentValue = "0100";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "3")
            {
                currentValue = "0011";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "2")
            {
                currentValue = "0010";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "1")
            {
                currentValue = "0001";
            }
            else if (hexadecimalNumber.ElementAt(hexadecimalNumber.Length - 1 - i).ToString() == "0")
            {
                currentValue = "0000";
            }
            binaryNumber = binaryNumber + currentValue;
        }
        Console.WriteLine(binaryNumber);
    }
}

