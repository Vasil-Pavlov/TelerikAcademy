using System;
using System.Linq;

class StringSort
{
    static void Main()
    {
        string[] arr = { "Disturb", "As", "There", "No", "Can" };
        var result = arr.OrderBy(a => a.Length);
        foreach (var res in result)
        {
            Console.WriteLine(res);
        }
    }
}

