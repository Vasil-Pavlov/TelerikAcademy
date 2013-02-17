using System;
using System.IO;
using System.Text.RegularExpressions;

class WordsCount
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\test.txt");
        StreamReader reader2 = new StreamReader(@"..\..\words.txt");
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");
        string line = "";
        string[] words = new string[10];
        string pat1 = @"(\b|\s|\W)";
        string pat2 = @"(\W|\b|\s|$)";
        string pat = "";
        int count = 0;
        int[] counts = new int[30];

        try
        {
            using (reader)
            {
                using (reader2)
                {
                    string word = reader2.ReadToEnd();
                    words = word.Split('\n');
                }
                do
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    count = 0;
                    foreach (string item in words)
                    {
                        pat = pat1 + item.ToString().Trim() + pat2;

                        foreach (Match m in Regex.Matches(line, pat))
                        {

                            if (m.Success)
                            {
                                counts[count]++;

                            }
                        }
                        count++;
                    }
                }
                while (line != null);
            }
            string[] output = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                output[i] = counts[i] + " " + words[i].ToString().Trim();
            }
            Array.Sort(output);
            using (writer)
            {
                for (int i = 0; i < output.Length; i++)
                {
                    writer.WriteLine(output[output.Length - i - 1]);
                }
            }

        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Cant File Find");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory Not Find");
        }
        catch (IOException)
        {
            Console.WriteLine("Cant Open file");
        }
    }
}

