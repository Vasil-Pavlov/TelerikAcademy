using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        number = number / 100;
        int thirdDigit = number % 10;

        if (thirdDigit != 0 && thirdDigit % 7 == 0)
        {
            Console.WriteLine("The third digit from right to left is 7");
        }
        else
        {
            Console.WriteLine("The third digit from right to left is not 7");
        }
    }
}

