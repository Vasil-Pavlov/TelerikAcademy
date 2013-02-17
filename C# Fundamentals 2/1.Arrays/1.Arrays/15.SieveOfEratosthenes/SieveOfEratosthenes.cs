using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        long[] numbers = new long[10000000];
        for (long i = 0; i < 10000000; i++)
        {
            numbers[i] = i + 1;
        }
        long divider;
        long limit = (long)Math.Sqrt(10000000);

        for (long i = 2; i < limit && numbers[i] != 0; i += 2)
        {
            if (numbers[i] != 0)
            {
                divider = numbers[i];
                for (long j = (numbers[i] * numbers[i]) - 1; j < numbers.Length && numbers[j] != 0; j += 2)
                {
                    if (numbers[j] % divider == 0)
                    {
                        numbers[j] = 0;
                    }
                }
            }
        }
        Console.Write("2 ");

        for (long i = 2; i < numbers.Length; i += 2)
        {
            if (numbers[i] != 0)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}