using System;
using System.Linq;

class ComparingFloatingVariables
{
    static void Main()
    {
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        decimal secondNumber = decimal.Parse(Console.ReadLine());

        bool comparisonResult;

        if (Math.Round(firstNumber, 6) != Math.Round(secondNumber, 6))
        {
            comparisonResult = false;
        }
        else
        {
            comparisonResult = true;
        }
        Console.WriteLine(comparisonResult);
    }
}

