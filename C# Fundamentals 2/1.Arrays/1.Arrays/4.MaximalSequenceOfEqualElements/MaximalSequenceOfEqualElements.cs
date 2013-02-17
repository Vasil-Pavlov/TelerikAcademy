using System;

class MaximalSequenceOfEqualElements
{
    static void Main()
    {
        int[] array = new int[10]{2,2,2,2,2,2,3,1,4,3};
        int currentCount = 1;
        int totalCount = 1;
        int targetElement = 0;

        for (int i = 0; i <array.Length-1; i++)
        {
            if (array[i]==array[i+1])
            {
                currentCount++;
                if (currentCount>=totalCount)
                {
                    totalCount = currentCount;
                    targetElement = array[i];
                }
            }
            else
            {
                currentCount = 1;
            }  
        }

        Console.Write("==> {");
        for (int j = 1; j <= totalCount; j++)
        {
            Console.Write("{0}", targetElement);
            if (j<totalCount)
            {
                Console.Write(", ");
            }
        }
        Console.Write("}.");
        Console.WriteLine();
    }
}

