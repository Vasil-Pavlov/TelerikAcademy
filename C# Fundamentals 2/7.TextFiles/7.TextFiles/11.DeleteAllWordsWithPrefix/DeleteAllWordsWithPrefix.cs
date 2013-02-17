using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteAllWordsWithPrefix
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\UndeletedFile.txt");
        StreamWriter writer = new StreamWriter(@"..\..\DeletedFile.txt");
        string line = "";
        string pattern = @"test(\w*|\n)*";

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
                    foreach (Match m in Regex.Matches(line, pattern))
                    {
                        if (m.Success)
                        {

                            line = line.Remove(line.IndexOf(m.Value), m.Value.Length);
                        }
                    }
                    writer.WriteLine(line);
                }
                while (line != null);
            }
        }
    }
}

