using System;

class DescendingSort
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int biggestNumber=0;
        int middleNumber=0;
        int smallestNumber=0;

        if (firstNumber>=secondNumber && firstNumber>=thirdNumber)
        {
            biggestNumber = firstNumber;

            if (secondNumber>=thirdNumber)
            {
                middleNumber = secondNumber;
                smallestNumber = thirdNumber;
            }
            else
            {
                middleNumber = thirdNumber;
                smallestNumber = secondNumber;
            }
        }

        if (secondNumber>=firstNumber && secondNumber>=thirdNumber)
        {
            biggestNumber = secondNumber;

            if (firstNumber>=thirdNumber)
            {
                middleNumber = firstNumber;
                smallestNumber = thirdNumber;
            }
            else
            {
                middleNumber = thirdNumber;
                smallestNumber = firstNumber;
            }
        }

        if (thirdNumber>=firstNumber && thirdNumber>=secondNumber)
        {
            biggestNumber = thirdNumber;

            if (firstNumber>=secondNumber)
            {
                middleNumber = firstNumber;
                smallestNumber = secondNumber;
            }
            else
	        {
                middleNumber = secondNumber;
                smallestNumber = firstNumber;
	        }
        }

        Console.WriteLine("{0} {1} {2}", biggestNumber, middleNumber, smallestNumber);
    }
}

