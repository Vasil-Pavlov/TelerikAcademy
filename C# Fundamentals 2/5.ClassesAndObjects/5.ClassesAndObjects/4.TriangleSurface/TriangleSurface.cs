using System;

class TriangleSurface
{
    public static double surfaceTriangleAhA(double side, double altitude)
    {
        return (side * altitude) / 2;
    }

    public static double surfaceTriangleTreeSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
    }

    public static double surfaceTriangleTwoSidesAndAngle(double a, double b, double angle)
    {
        return a * b * Math.Sin(angle) / 2;
    }

    static void Main()
    {
        int firstSide = int.Parse(Console.ReadLine());
        int secondSide = int.Parse(Console.ReadLine());
        int thirdSide = int.Parse(Console.ReadLine());
        int altitude = int.Parse(Console.ReadLine());
        int angle = int.Parse(Console.ReadLine());
        Console.WriteLine(surfaceTriangleAhA(firstSide, altitude));
        Console.WriteLine(surfaceTriangleTreeSides(firstSide, secondSide, thirdSide));
        Console.WriteLine(surfaceTriangleTwoSidesAndAngle(firstSide, secondSide, angle));
    }
}

