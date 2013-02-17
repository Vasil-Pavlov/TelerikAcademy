using System;

class InternalBinaryRepresentation
{
    static void Main()
    {
        float number = -27.25f;
        long bytes = (BitConverter.DoubleToInt64Bits(number));
        string bytesConverter = Convert.ToString(bytes, 2);
        int sign = 0;
        string exponenta = "1" + bytesConverter.Substring(5, 7);
        string mantissa = bytesConverter.Substring(5 + 7, 23);

        if (number < 0)
        {
            sign = 1;
        }
        Console.WriteLine("sign = {0}, exponenta = {1}, mantissa = {2}", sign, exponenta, mantissa);
    }
}

