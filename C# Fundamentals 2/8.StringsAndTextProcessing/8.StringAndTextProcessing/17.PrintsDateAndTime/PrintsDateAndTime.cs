using System;
using System.Text;
using System.Globalization;

class PrintsDateAndTime
{
    static void Main()
    {
        CultureInfo provider = CultureInfo.CurrentCulture;
        string format = "d.MM.yyyy hh:mm:ss";

        Console.Write("Enter the date: ");
        string date1 = Console.ReadLine();
        DateTime date = DateTime.ParseExact(date1, format, provider);
        date = date.AddMinutes(30);
        date = date.AddHours(6);
        Console.WriteLine(date);

        switch (date.DayOfWeek)
        {
            case DayOfWeek.Friday:
                Console.WriteLine("Petuk");
                break;
            case DayOfWeek.Monday:
                Console.WriteLine("Ponedelnik");
                break;
            case DayOfWeek.Saturday:
                Console.WriteLine("Subota");
                break;
            case DayOfWeek.Sunday:
                Console.WriteLine("Nedelq");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("Vtornik");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("Chetvurtuk");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("Srqda");
                break;
        }

    }
}

