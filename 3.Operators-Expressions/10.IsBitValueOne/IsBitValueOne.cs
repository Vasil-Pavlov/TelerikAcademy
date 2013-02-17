using System;

class IsBitValueOne
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int bitPosition = int.Parse(Console.ReadLine());
        int bitValue=(number>>bitPosition)&1;
        bool isBitValueOne=true;

        if (bitValue==1)
        {
            Console.WriteLine(isBitValueOne);;
        }
        else
        {
            Console.WriteLine(!isBitValueOne);
        }
    }
}

