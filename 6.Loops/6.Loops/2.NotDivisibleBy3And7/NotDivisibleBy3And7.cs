using System;

class NotDivisibleBy3And7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (i%21!=0)
            {
                Console.Write(" {0}",i);
            }
        }
        Console.WriteLine();
    }
}

