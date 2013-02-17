using System;

class GCD
{
    static int GreatestCommonDivisor(int number1,int number2)
    {
        while (number1!=0 && number2!=0)
        {
            if (number1>number2)
            {
                number1 %= number2;
            }
            else
            {
                number2 %= number1;
            }
        }

        if (number1==0)
        {
            return number2;   
        }
        else
        {
            return number1;
        }
    }

    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(GreatestCommonDivisor(firstNumber,secondNumber));
    }
}

