using System;

class RectangleArea
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        int area;

        if (width > 0 && height > 0)
        {
            area = width * height;
            Console.WriteLine("{0}", area);
        }
        else
        {
            Console.WriteLine("Negative values are not permitted for a triangle.");
        }
    }
}

