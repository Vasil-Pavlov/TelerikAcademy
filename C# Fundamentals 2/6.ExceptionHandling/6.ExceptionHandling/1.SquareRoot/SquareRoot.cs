using System;

class SquareRoot
{
    static void Main()
    {
        int number = 0;

        try
        {
            number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid Number.");
            }
            Console.WriteLine(Math.Sqrt(number));
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid Number.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid Number.");
        }

        finally
        {
            Console.WriteLine("Good Bye!");
        }
    }
}

