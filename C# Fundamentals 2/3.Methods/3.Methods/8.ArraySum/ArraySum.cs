using System;

class ArraySum
{
    static void AddArrayNumbers(byte[] number1, byte[] number2)
    {
        if (number2.Length > number1.Length)
        {
            byte[] temp = number1;
            number1 = number2;
            number2 = temp;
        }
        for (int i = 1; i <= number2.Length; i++)
        {
            number1[number1.Length - i] += number2[number2.Length - i];
            if (number1[number1.Length - i] > 9)
            {
                number1[number1.Length - i] %= 10;
                number1[number1.Length - i - 1]++;
            }
        }
        Console.WriteLine(number1.ToString());
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        byte[] firstNumber = new byte[n];
        byte[] secondNumber = new byte[n];
        for (int i = 0; i < firstNumber.Length; i++)
        {
            firstNumber[i] = byte.Parse(Console.ReadLine());
        }
        for (int i = 0; i < secondNumber.Length; i++)
        {
            secondNumber[i] = byte.Parse(Console.ReadLine());
        }
        AddArrayNumbers(firstNumber, secondNumber);
    }
}

