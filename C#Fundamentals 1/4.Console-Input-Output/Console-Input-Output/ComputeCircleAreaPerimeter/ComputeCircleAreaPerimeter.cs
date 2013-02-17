using System;
using System.Linq;

class ComputeCircleAreaPerimeter
{
    static void Main()
    {
        int radius = int.Parse(Console.ReadLine());

        if (radius > 0)
        {
            double area = (Math.PI) * radius * radius;
            double perimeter = 2 * (Math.PI) * radius;
            Console.WriteLine("The area is: {0}", area);
            Console.WriteLine("The perimeter is: {0}", perimeter);
        }
        else
        {
            Console.WriteLine("Radius of a circle must be a positive number!");
        }
    }
}

