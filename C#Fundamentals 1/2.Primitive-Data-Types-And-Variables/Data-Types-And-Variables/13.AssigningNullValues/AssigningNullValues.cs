using System;

class AssigningNullValues
{
    static void Main()
    {
        int? firstVariable = null;
        double? secondVariable=null ;
        double ?thirdVariable = null;
        double ?sum = secondVariable + thirdVariable;
        Console.WriteLine("{0} {1} {2}",firstVariable,secondVariable,thirdVariable);
        Console.WriteLine(sum);
    }
}

