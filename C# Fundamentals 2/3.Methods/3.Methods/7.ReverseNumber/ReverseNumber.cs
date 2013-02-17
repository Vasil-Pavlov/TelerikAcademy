using System;

class ReverseANumber
{
    static int ReverseNumber(int number)
    {
        int reverse = 0;
        while (number > 0)
        {
            int remainder = number % 10;
            reverse = (reverse * 10) + remainder;
            number = number / 10;
        }
        return reverse;
    }

    static void Main()
    {
        Console.WriteLine("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(ReverseNumber(number));
    }
}

