using System;

class ExchangeBit
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine()); 
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int intNumber = (int)number;

        for (int i = 0; i < k; i++)
        {
            number = ExchangeBits((int)number, p+i, (intNumber>>q+i) & 1);
            number = ExchangeBits((int)number, q+i, (intNumber>>p+i) & 1);
        }
        Console.WriteLine(number);
    }

    static UInt32 ExchangeBits(int number, int position, int value)
    {
        int mask;
        if (value == 1)
        {
            mask = 1 << position;
            return (UInt32)(mask | number);
        }
        else 
        {
            mask = ~(1 << position);
            return (UInt32)(mask & number);
        }
    }
}

    