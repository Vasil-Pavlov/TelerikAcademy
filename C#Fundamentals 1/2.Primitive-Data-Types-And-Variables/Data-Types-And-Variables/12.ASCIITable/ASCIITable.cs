using System;

class ASCIITable
{
    static void Main()
    {
        for (char symbol = '\0'; symbol < 128; symbol++)
        {
            Console.Write(" {0} ",symbol);
        }
    }
}
