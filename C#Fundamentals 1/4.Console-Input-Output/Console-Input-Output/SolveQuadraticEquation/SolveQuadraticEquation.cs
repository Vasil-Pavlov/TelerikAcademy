using System;
using System.Linq;

class SolveQuadraticEquation
{
    static void Main()
    {
      int a = int.Parse(Console.ReadLine());
      int b = int.Parse(Console.ReadLine());
      int c = int.Parse(Console.ReadLine());
      double d = (b * b)-(4*a*c);

      if (d>0)
      {
          double firstRoot = (-b + Math.Sqrt(d))/2*a;
          double secondRoot=(-b-Math.Sqrt(d)/2*a);
      }
      else if (d==0)
      {
          double root = -b / 2 * a;
      }
      else
      {
          Console.WriteLine("Wrong coefficients for either a or b or c, because the discriminant must be greater than zero!");
      }

    }
}