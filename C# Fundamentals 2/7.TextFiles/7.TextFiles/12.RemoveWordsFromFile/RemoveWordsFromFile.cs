using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

    class RemoveWordsFromFile
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\firstFile.txt");
            StreamReader reader2 = new StreamReader(@"..\..\words.txt");
            StreamWriter writer = new StreamWriter(@"..\..\secondFile.txt");
            string line = "";
            string[] words = new string[10];
            string pat1 = @"(\b|\s|\W)";
            string pat2 = @"(\W|\b|\s|$)";
            string pat = "";
            try
            {
                using (reader)
                {
                    using (reader2)
                    {
                        string word = reader2.ReadToEnd();
                        words = word.Split('\n');
                    }
                    using (writer)
                    {
                        do
                        {
                            line = reader.ReadLine();
                            if (line == null)
                            {
                                break;
                            }
                            foreach (string item in words)
                            {
                                pat = pat1 + item.ToString().Trim() + pat2;

                                foreach (Match m in Regex.Matches(line, pat))
                                {

                                    if (m.Success)
                                    {

                                        line = line.Remove(line.IndexOf(m.Value), m.Value.Length);

                                    }

                                }
                            }
                            writer.WriteLine(line);
                        }
                        while (line != null);
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

