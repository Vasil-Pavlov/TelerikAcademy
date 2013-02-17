using System;

class CurrentDay
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine(date.DayOfWeek);
    }
}

