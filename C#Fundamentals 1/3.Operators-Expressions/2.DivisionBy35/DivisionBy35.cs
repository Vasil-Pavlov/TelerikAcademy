using System;

class DivisionBy35
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool checker = true;

        if (number % 35 == 0)
        {
            Console.WriteLine("{0}", checker);
        }
        else
        {
            Console.WriteLine("{0}", !checker);
        }
    }
}

