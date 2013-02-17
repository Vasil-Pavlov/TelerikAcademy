using System;

class ReadNumbers
{
    static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());

        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException("Invalid Number");
        }
        return number;
    }

    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(ReadNumber(1, 100));
        }

    }
    
}

