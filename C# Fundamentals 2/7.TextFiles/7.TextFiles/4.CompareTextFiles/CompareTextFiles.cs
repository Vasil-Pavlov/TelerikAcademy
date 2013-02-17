using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\FirstFile.txt");
        StreamReader reader2 = new StreamReader(@"..\..\SecondFile.txt");
        int equal = 0;
        int notEqual = 0;

        using (reader)
        {
            using (reader2)
            {
                string line1 = "";
                string line2 = "";
                do
                {
                    line1 = reader.ReadLine();
                    line2 = reader2.ReadLine();

                    if (line1 == null)
                    {
                        break;
                    }
                    if (line2 == null)
                    {
                        break;
                    }
                    if (line1.Equals(line2) == true)
                    {
                        equal++;
                    }
                    else
                    {
                        notEqual++;
                    }
                }
                while (true);
            }
        }
        Console.WriteLine("Equal lines:{0}, Not equal: {1}", equal, notEqual);
    }
}

