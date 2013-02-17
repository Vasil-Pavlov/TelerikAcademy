using System;
using System.Linq;

class WithinCircleOutOfRectangle
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int radius = 3;
        double line = Math.Sqrt(x*x+y*y);
        bool isInCircle = (radius >= line);
        bool outOfTheRectangle=((x<-1) || (x>5) || (y>1) || (y<-1));
        
        if (isInCircle)
        {
            Console.WriteLine("The point is within the circle.");
        }
        else
        {
            Console.WriteLine("The point is out of the circle.");
        }

        if (outOfTheRectangle)
        {
            Console.WriteLine("The point is out of the rectangle.");
        }
        else
        {
            Console.WriteLine("The point is within the rectangle.");
        }
    }
}

