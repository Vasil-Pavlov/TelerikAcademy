using System;
using System.Linq;

class PointsWithinCircle
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        double radius = 5;
        double line = Math.Sqrt(x*x+y*y);

        if (radius>=line)
        {
            Console.WriteLine("Point with coordinates ({0},{1}) is within the circle.",x,y);
        }
        else
        {
            Console.WriteLine("Point with coordinates ({0},{1}) is not within the circle.",x,y);
        }
    }
}

