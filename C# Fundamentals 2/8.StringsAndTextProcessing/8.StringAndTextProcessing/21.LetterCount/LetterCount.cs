using System;
using System.Text;

class LetterCount
{
    static void Main()
    {
        int[] arr = new int[65536];
        string text = " fds gfdrsg dfg dfh dh gfhf khgf khl al 4o2 4k 4rkkdfg ldf dfoh oro 4o545o4o56654 54  #$ %$ $^ % #$ #% Y%& ^%^ %^ #$#$^^%^% ^% ^% % fds dfs gdfgh dh dhd hd r3oasr opf  fds fks fklsf";

        foreach (char ch in text)
        {
            arr[(int)ch]++;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                Console.WriteLine((char)i + " " + arr[i]);
            }
        }
    }
}

