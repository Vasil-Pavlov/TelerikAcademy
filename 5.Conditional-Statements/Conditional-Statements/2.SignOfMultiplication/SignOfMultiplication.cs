using System;

class SignOfMultiplication
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        bool firstPositiveCombination=(firstNumber>0 && secondNumber>0 && thirdNumber>0);
        bool secondPositiveCombination=(firstNumber<0 && secondNumber<0 && thirdNumber>0);
        bool thirdPositiveCombination=(firstNumber<0 && secondNumber>0 && thirdNumber<0);
        bool forthPositiveCombination=(firstNumber>0 && secondNumber<0 && thirdNumber<0);
        bool firstNegativeCombination=(firstNumber>0 && secondNumber<0 && thirdNumber>0);
        bool secondNegativeCombination=(firstNumber<0 && secondNumber>0 && thirdNumber>0);
        bool thirdNegativeCombination=(firstNumber>0 && secondNumber>0 && thirdNumber<0);
        bool forthNegativeCombination=(firstNumber<0 && secondNumber<0 && thirdNumber<0);

        if (firstPositiveCombination||secondPositiveCombination||thirdPositiveCombination||forthPositiveCombination)
        {
            Console.WriteLine("The the sign of the product is +");
        }
        else if (firstNegativeCombination||secondNegativeCombination||thirdNegativeCombination||forthNegativeCombination)
        {
            Console.WriteLine("The sign of the product is -");
        }
    }
}

