using System;

class PrintingIndexOfLetters
{
    static void Main()
    {
        char[] arr = new char[28];
        for (int i = 0; i <= 25; i++)
        {
            arr[i] = (char)(i + 65);
        }
        string word = "Vasil";
        word = word.ToUpper();

        for (int i = 0; i < word.Length; i++)
        {
            int min = 0;
            int max = arr.GetLength(0) - 1;
            int mid;
            char x = word[i];
            do
            {
                mid = (min + max) / 2;
                if (x > arr[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            while (arr[mid] != x && (min <= max));
            Console.WriteLine("arr[{0}] is equal to {1}", mid, x);
        }
    }
}

