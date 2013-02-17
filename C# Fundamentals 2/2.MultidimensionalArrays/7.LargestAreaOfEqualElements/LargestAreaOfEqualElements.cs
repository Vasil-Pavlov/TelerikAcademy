using System;
using System.Collections.Generic;

class LargestAreaOfEqualElements
{
    static void Main()
    {
        int[,] arr = 
            {
                {1,3,2,2,2,4},
                {3,3,3,2,4,4},
                {4,3,1,2,3,3},
                {4,3,1,3,3,1},
                {4,3,3,3,1,1}
            };
        int max = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                int cur = BreadthFirstSearch(arr, i, j);
                if (max < cur)
                {
                    max = cur;
                }
            }
        }
        Console.WriteLine(max);
    }

    struct Cordinate
    {
        public int x;
        public int y;
    }

    static int BreadthFirstSearch(int[,] arr, int k, int l)
    {
        int[,] arr2 = new int[arr.GetLength(0), arr.GetLength(1)];
        Queue<Cordinate> que = new Queue<Cordinate>();
        int count = 1;
        Cordinate t = new Cordinate();
        Cordinate z = new Cordinate();
        t.x = k;
        t.y = l;
        que.Enqueue(t);
        arr2[k, l] = -1;
        while (que.Count != 0)
        {
            t = que.Dequeue();
            if ((t.x - 1) >= 0)
            {
                if (arr[t.x - 1, t.y] == arr[t.x, t.y] && arr2[t.x - 1, t.y] != -1)
                {
                    z.x = t.x - 1;
                    z.y = t.y;
                    que.Enqueue(z);
                    arr2[t.x - 1, t.y] = -1;
                    count++;
                }
            }
            if ((t.x + 1) < arr.GetLength(0))
            {
                if (arr[t.x + 1, t.y] == arr[t.x, t.y] && arr2[t.x + 1, t.y] != -1)
                {
                    z.x = t.x + 1;
                    z.y = t.y;
                    que.Enqueue(z);
                    arr2[t.x + 1, t.y] = -1;
                    count++;
                }
            }
            if ((t.y - 1) >= 0)
            {
                if (arr[t.x, t.y - 1] == arr[t.x, t.y] && arr2[t.x, t.y - 1] != -1)
                {
                    z.x = t.x;
                    z.y = t.y - 1;
                    que.Enqueue(z);
                    arr2[t.x, t.y - 1] = -1;
                    count++;
                }
            }
            if ((t.y + 1) < arr.GetLength(1))
            {
                if (arr[t.x, t.y + 1] == arr[t.x, t.y] && arr2[t.x, t.y + 1] != -1)
                {
                    z.x = t.x;
                    z.y = t.y + 1;
                    que.Enqueue(z);
                    arr2[t.x, t.y + 1] = -1;
                    count++;
                }
            }
        }
        return count; 
    }
}

