using System;
using System.IO;

class ConcatenateFiles
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\firstFile.txt");
        StreamReader reader2 = new StreamReader(@"..\..\secondFile.txt");
        StreamWriter writer = new StreamWriter(@"..\..\concatenatedFile.txt");
        string read1 = "";
        string read2 = "";

        using (reader)
        {
            read1 = reader.ReadToEnd();
        }
        using (reader2)
        {
            read2 = reader2.ReadToEnd();
        }
        using (writer)
        {
            writer.WriteLine(read1);
            writer.WriteLine(read2);
        }
    }
}

