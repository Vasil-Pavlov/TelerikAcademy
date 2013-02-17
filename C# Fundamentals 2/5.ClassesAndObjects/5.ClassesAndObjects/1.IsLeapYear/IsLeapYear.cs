using System;

class IsLeapYear
{
    static void Main()
    {
        int year = Int32.Parse(Console.ReadLine());
        bool leapYear = DateTime.IsLeapYear(year);

        if (leapYear == true)
        {
            Console.WriteLine("The year is leap");
        }
        else
        {
            Console.WriteLine("The year is not leap");
        }
    }
}

