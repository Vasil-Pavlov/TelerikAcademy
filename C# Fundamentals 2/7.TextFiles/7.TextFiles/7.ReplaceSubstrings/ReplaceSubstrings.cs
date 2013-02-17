using System;
using System.IO;

class ReplaceSubstrings
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\UnreplacedFile.txt");
        StreamWriter writer = new StreamWriter(@"..\..\ReplacedFile.txt");
        string line = "";

        using (reader)
        {
            using (writer)
            {
                do
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    line = line.Replace("start", "finish");
                    writer.WriteLine(line);
                }
                while (line != null);
            }
        }
    }
}

