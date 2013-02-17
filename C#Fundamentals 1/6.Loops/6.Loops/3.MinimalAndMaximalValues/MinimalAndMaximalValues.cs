using System;

class MinimalAndMaximalValues
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int minimalValue = int.Parse(Console.ReadLine()); 
        int maximalValue=minimalValue;
        int number;

        for (int i = 1; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());

            if (maximalValue<number)
            {
                maximalValue = number;
            }
            if (minimalValue>number)
            {
                minimalValue = number;
            }
        }
        Console.WriteLine("The maximal value of the sequence is {0} and the minimal value of the sequence is {1}",maximalValue,minimalValue);
    }
}
