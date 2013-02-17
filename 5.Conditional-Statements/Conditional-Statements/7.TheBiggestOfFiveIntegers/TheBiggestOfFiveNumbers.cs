using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int forthNumber = int.Parse(Console.ReadLine());
        int fifthNumber = int.Parse(Console.ReadLine());
        int biggestNumber=0;

        if (firstNumber>secondNumber && firstNumber>thirdNumber && 
            firstNumber>forthNumber && firstNumber>fifthNumber )
        {
            biggestNumber = firstNumber;
        }
        else if (secondNumber>firstNumber && secondNumber>thirdNumber 
            && secondNumber>forthNumber && secondNumber>fifthNumber)
        {
            biggestNumber = secondNumber;
        }
        else if (thirdNumber>firstNumber && thirdNumber>secondNumber 
            && thirdNumber>forthNumber && thirdNumber>fifthNumber)
        {
            biggestNumber = thirdNumber;
        }
        else if (forthNumber>firstNumber && forthNumber>secondNumber
            && forthNumber>thirdNumber && forthNumber>fifthNumber)
        {
            biggestNumber = forthNumber;
        }
        else
        {
            biggestNumber = fifthNumber;
        }
        Console.WriteLine(biggestNumber);
    }
}

