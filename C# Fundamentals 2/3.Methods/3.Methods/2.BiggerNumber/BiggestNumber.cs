using System;

class BiggestNumber
{
    static int GetMax(int num1, int num2, int num3)
    {
        int max = num1;

        if (num2 > max)
        {
            max = num2;
        }
        else if (num3 > max)
        {
            max = num3;
        }
        return max;
    }

    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int max = GetMax(number1, number2, number3);
        Console.WriteLine(max);
    }
}