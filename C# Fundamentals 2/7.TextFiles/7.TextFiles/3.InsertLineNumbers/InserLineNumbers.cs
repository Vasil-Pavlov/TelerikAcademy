using System;
using System.IO;

class InserLineNumbers
{
    static void Main()
    {

        StreamReader reader = new StreamReader(@"..\..\Lines.txt");
        StreamWriter writer = new StreamWriter(@"..\..\NumberedLines.txt");

        using (reader)
        {
            int count = 1;
            string line = "";
            using (writer)
            {
                do
                {
                    line = reader.ReadLine();
                    if (line==null)
                    {
                        return;
                    }
                    writer.WriteLine(count+ ". " + line);
                    count++;
                }
                while (line != null);
            }    
        }
    }
}


