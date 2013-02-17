using System;
using System.IO;

class SortFile
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\UnsortedFile.txt");
        StreamWriter writer = new StreamWriter(@"..\..\SortedFile.txt");
        string mat = "";

        using (reader)
        {
            mat = reader.ReadToEnd();
        }

        string[] matrix = mat.Split('\n');
        Array.Sort(matrix);

        using (writer)
        {
            foreach (string item in matrix)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    writer.WriteLine(item.Trim());
                }
            }
        }
    }
}

