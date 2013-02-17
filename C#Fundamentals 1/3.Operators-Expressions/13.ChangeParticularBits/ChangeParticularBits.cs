using System;

class ChangeParticularBits
{
    static uint ExchangeBitsValues(int number, int position, int value)
    {
        int mask;
        if (value == 1)
        {
            mask = (1 << position);
            return (uint)(number | mask);
        }
        else
        {
            mask = ~(1 << position);
            return (uint)(number & mask);
        }
    }

    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int integerNumber=(int)number;
        int thirdBit=(integerNumber>>3)&1;
        int forthBit = (integerNumber>>4)&1;
        int fifthBit=(integerNumber>>5)&1;
        int twentyForthBit=(integerNumber>>24)&1;
        int twentyFifthBit=(integerNumber>>25)&1;
        int twentySixthBit=(integerNumber>>26)&1;

        number=ExchangeBitsValues((int)number,3,twentyForthBit);
        number=ExchangeBitsValues((int)number,4,twentyFifthBit);
        number=ExchangeBitsValues((int)number,5,twentySixthBit);
        number = ExchangeBitsValues((int)number, 24, thirdBit);
        number = ExchangeBitsValues((int)number, 25, forthBit);
        number = ExchangeBitsValues((int)number, 26, fifthBit);

        Console.WriteLine(number);
    }

}

