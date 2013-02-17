using System;

class ValueOfThirdBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int thirdBit = (number >> 3)&1;

        if (thirdBit == 1)
        {
            Console.WriteLine("Third bit is {0}.", thirdBit);
        }
        if(thirdBit==0)
        {
            Console.WriteLine("Third bit is {0}.", thirdBit);
        }
    }
}

