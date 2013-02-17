using System;

class TrapezoidArea
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double area = (double)(((a + b) * h)) / 2;

        Console.WriteLine("{0}", area);
    }
}

