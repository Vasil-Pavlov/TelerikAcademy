using System;

class WorkDays
{
    public static int CalculateWorkDays(DateTime end)
    {
        DateTime[] holidays = new DateTime[20];
        holidays[0] = new DateTime(2012, 1, 22);
        holidays[1] = new DateTime(2012, 1, 24);
        DateTime now = DateTime.Today;
        int midDays = end.DayOfYear - now.DayOfYear;
        int worked = midDays - 2 * (midDays / 7);

        if (worked <= 0)
        {
            return 0;
        }

        switch (now.DayOfWeek)
        {
            case DayOfWeek.Thursday:
                worked--;
                break;
            case DayOfWeek.Wednesday:
                worked -= 2;
                break;
            case DayOfWeek.Tuesday:
                worked -= 3;
                break;
            case DayOfWeek.Friday:
                worked -= 4;
                break;
            case DayOfWeek.Saturday:
                worked -= 5;
                break;
            case DayOfWeek.Sunday:
                worked -= 6;
                break;

        }
        foreach (var i in holidays)
        {
            if (i.DayOfYear > now.DayOfYear && i.DayOfYear < end.DayOfYear)
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                {
                    worked--;
                }
            }
        }
        return worked;
    }

    static void Main()
    {
        DateTime end = new DateTime(2012, 2, 5);
        Console.WriteLine(CalculateWorkDays(end));
    }
}

