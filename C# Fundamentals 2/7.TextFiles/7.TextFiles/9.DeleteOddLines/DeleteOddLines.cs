using System;
using System.IO;
using System.Text;

class DeleteOddLines
{
    static void Main()
    {
        StreamReader inputReader = new StreamReader(@"..\..\Input.txt");
        StringBuilder result = new StringBuilder();
        using (inputReader)
        {
            int lineNumber = 0;
            result.Append("Result: \r\n");
            while (inputReader.EndOfStream != true)
            {
                string line = inputReader.ReadLine();
                lineNumber++;
                if (lineNumber % 2 == 0)
                {
                    result.Append(line);
                    result.Append("\r\n");
                }
            }
        }

        StreamWriter outputWriter = new StreamWriter(@"..\..\Input.txt", false);
        using (outputWriter)
        {
            outputWriter.WriteLine(result.ToString());
        }    
        
    }


}