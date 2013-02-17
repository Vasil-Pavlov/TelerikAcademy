using System;
using System.Linq;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double discriminant = (b * b) - 4 * a * c;
        double firstRoot=0;
        double secondRoot=0;

        if (discriminant>0)
	    {
            firstRoot = (-b + (Math.Sqrt(discriminant) / 2 * a));
            secondRoot = (-b - (Math.Sqrt(discriminant) / 2 * a));
	    }
        else if (discriminant==0)
        {
            firstRoot=secondRoot=(-b/2*a);
        }
        else
        {
            Console.WriteLine("Wrong coefficients! The discriminant cannot be a negative number!");
            return;
        }
        Console.WriteLine("{0}, {1}",firstRoot,secondRoot);
    }
}

