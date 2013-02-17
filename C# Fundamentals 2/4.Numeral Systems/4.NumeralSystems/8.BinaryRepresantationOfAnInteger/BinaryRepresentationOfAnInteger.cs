using System;

class BinaryRepresentationOfAnInteger
{
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        string str = Convert.ToString(number, 2);

        if (number < 0)
        {
            Console.WriteLine("{0}{1}", new String('0', (16 - str.Length)), str);
        }
        else
        {
            Console.WriteLine("1{0}{1}", new String('0', (15 - str.Length)), str);
        }
    }
}

