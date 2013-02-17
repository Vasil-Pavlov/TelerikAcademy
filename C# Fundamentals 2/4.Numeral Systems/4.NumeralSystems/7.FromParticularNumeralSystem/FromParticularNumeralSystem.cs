using System;

class FromParticularNumeralSystem
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        string input = Console.ReadLine(); 

        long initialSystem = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            long currentValue = long.Parse((input[input.Length - 1 - i].ToString()));
            initialSystem = initialSystem + currentValue * (long)(Math.Pow(s, i));
        }

        long n = (long)Math.Log(initialSystem, d) + 1;
        int count = 0;
        long[] array = new long[n];

        do
        {
            array[count] = initialSystem % d;
            initialSystem = initialSystem / d;
            count++;
        } 
        while (initialSystem != 0);

        Array.Reverse(array);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 10)
            {
                Console.Write("A");
            }
            else if (array[i] == 11)
            {
                Console.Write("B");
            }
            else if (array[i] == 12)
            {
                Console.Write("C");
            }
            else if (array[i] == 13)
            {
                Console.Write("D");
            }
            else if (array[i] == 14)
            {
                Console.Write("E");
            }
            else if (array[i] == 15)
            {
                Console.Write("F");
            }
            else
                Console.Write(array[i]);
        }
    }
}

