using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWords
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\UnreplacedFile.txt");
        StreamWriter writer = new StreamWriter(@"..\..\ReplacedFile.txt");
        string line = "";
        string pat = @"(\b|\s|\W)start(\W|\b|\s|$)";

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
                    foreach (Match m in Regex.Matches(line, pat))
                    {

                        if (m.Success)
                        {

                            string a = line.Substring(0, line.IndexOf("s", m.Index));
                            line = a + "finish" + line.Substring(line.IndexOf("s", m.Index) + 5);
                        }
                    }
                    writer.WriteLine(line);
                }
                while (line != null);
            }
        } 
    }
}

