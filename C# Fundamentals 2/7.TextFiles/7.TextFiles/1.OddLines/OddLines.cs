using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        string fileName = @"..\..\OddLines.txt";
        StreamReader reader = new StreamReader(fileName);

        using (reader)
        {
            int count = 1;
            string line = "";
            do
            {
                line = reader.ReadLine();
                if (line==null)
                {
                    return;   
                }
                if (count % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                count++;
            }
            while (line != null);
        }
    }
}
