using System;

class EqualElements
{
    static void Main()
    {
        string[,] array = {
                            { "pate", "3", "3", "2", "fds", "fd" },
                            { "3", "pate", "4", "3", "fds", "1" },
                            { "3", "3", "pate", "8", "fd", "3" },
                            { "4", "6", "4", "pate", "f", "3" }
            };
        string buf;
        int currentCount = 0;
        int maxCount = 0;
        string maxNumber = "";
        string number;

        number = array[0, 0];
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                buf = array[j, i];
                if (number == buf)
                {
                    currentCount++;
                    if (i == (array.GetLength(1) - 1) && maxCount < currentCount)
                    {
                        maxCount = currentCount;
                        maxNumber = buf;
                    }
                }
                else
                {
                    if (maxCount < currentCount)
                    {
                        maxCount = currentCount;
                        maxNumber = array[j, i - 1];
                    }
                    currentCount = 0;
                    number = buf;
                    currentCount++;
                }

            }
            currentCount = 0;
        }
        number = array[0, 0];

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                buf = array[i, j];
                if (number == buf)
                {
                    currentCount++;
                    if (i == (array.GetLength(0) - 1) && maxCount < currentCount)
                    {
                        maxCount = currentCount;
                        maxNumber = buf;
                    }
                }
                else
                {
                    if (maxCount < currentCount)
                    {
                        maxCount = currentCount;
                        maxNumber = array[i, j - 1];
                    }
                    currentCount = 0;
                    number = buf;
                    currentCount++;
                }
            }
            currentCount = 0;
        }

        number = array[0, 0];
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int i = j, k = 0; i < array.GetLength(0) && k < array.GetLength(1); i++, k++)
            {
                buf = array[i, k];
                if (number == buf)
                {
                    currentCount++;
                    if ((i == (array.GetLength(0) - 1) || k == (array.GetLength(1) - 1)) && maxCount < currentCount)
                    {
                        maxCount = currentCount;
                        maxNumber = buf;
                    }
                }
                else
                {
                    if (maxCount < currentCount)
                    {
                        maxCount = currentCount;
                        maxNumber = array[i, k - 1];
                    }
                    currentCount = 0;
                    number = buf;
                    currentCount++;
                }

            }
            currentCount = 0;
        }

        for (int i = 0; i < maxCount; i++)
        {
            Console.Write("{0} ", maxNumber);
        }
        Console.WriteLine();
    }
}

