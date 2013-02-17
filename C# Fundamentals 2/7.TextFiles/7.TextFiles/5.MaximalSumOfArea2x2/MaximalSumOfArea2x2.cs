using System;
using System.IO;

class MaximalSumOfArea2x2
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\matrix.txt");
        StreamWriter writer = new StreamWriter(@"..\..\MaximalSum.txt");
        int maximalSum = 0;
        int currentSum = 0;
        string separator = "";
        int n = 0;

        using (reader)
        {
            n = int.Parse(reader.ReadLine());
            separator = reader.ReadToEnd();
        }
        string[] matrix = separator.Split('\n');

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                currentSum = (int.Parse(matrix[i][j].ToString()) + int.Parse(matrix[i + 1][j].ToString()) +
                    int.Parse(matrix[i][j + 1].ToString()) + int.Parse(matrix[i + 1][j + 1].ToString()));
                if (currentSum > maximalSum)
                {
                    maximalSum = currentSum;
                }
            }
        }
        using (writer)
        {
            writer.WriteLine(maximalSum);
        }
    }
}

