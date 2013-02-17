using System;   

class ChangeDigits
{
    static void Main()
    {
        int number =int.Parse(Console.ReadLine());
        int bitPosition=int.Parse(Console.ReadLine());
        int bitValue = (number>>bitPosition)&1;

        if (bitValue==1)
        {
            number = number&(~(1<<bitPosition));
        }
        else
        {
            number=number|(1<<bitPosition);
        }
        Console.WriteLine(number);
    }
}

