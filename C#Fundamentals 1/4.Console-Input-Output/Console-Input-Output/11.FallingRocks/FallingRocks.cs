using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;


class FallingRocks
{
    struct elementsPosition
    {
        public int X, Y;
        public elementsPosition(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    static void Main()
    {
        elementsPosition[] dwarfElements = new elementsPosition[25];
        Random randomGenerator = new Random();

        Console.CursorVisible = false;
        Console.BufferHeight = Console.WindowHeight;

        for (int i = 0; i <= 23; i++)
        {
            dwarfElements[i] = (new elementsPosition(i + (Console.WindowWidth - 10) / 2, Console.WindowHeight - 1));
        }
        for (int i = 0; i <= 23; i++)
        {
            Console.SetCursorPosition(dwarfElements[i].X, dwarfElements[i].Y);
            Console.ForegroundColor = ConsoleColor.DarkGray;

            if (i == 0)
            {
                Console.Write("<");
            }
            if (i > 0 && i < 8)
            {
                Console.Write("-");
            }
            if (i == 8)
            {
                Console.Write(">");
            }
        }

        Queue<elementsPosition> rocks = new Queue<elementsPosition>();
        elementsPosition currentPosition;
        currentPosition.X = 0;
        currentPosition.Y = 0;
        int leftElement = 0;
        int rightElement = 22;
        int count = 0;
        int time = 20;
        int frequency = 5;
        int numberOfMaxRocks = 35;
        elementsPosition p;

        while (true)
        {
            if (count % frequency == 0 && rocks.Count < numberOfMaxRocks)
            {
                currentPosition.X = randomGenerator.Next(1, Console.WindowWidth - 2);
                currentPosition.Y = 0;
                rocks.Enqueue(currentPosition);
            }
            Console.SetCursorPosition(0, 0);

            if (count % 400 == 0)
            {
                time -= 1;
            }

            count++;
            currentPosition.Y = rocks.First().Y + 1;
            currentPosition.X = rocks.First().X;
            rocks.Enqueue(currentPosition);
            Console.SetCursorPosition(currentPosition.X, currentPosition.Y);
            Console.ForegroundColor = (ConsoleColor)randomGenerator.Next(1, 10);
            Console.Write("+");
            p = rocks.Dequeue();
            Console.SetCursorPosition(p.X, p.Y);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");

            if (rocks.First().Y > Console.WindowHeight - 3)
            {
                for (int i = 0; i < 23; i++)
                    if (dwarfElements[i].X == rocks.First().X)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Game Over!!!");
                        Console.WriteLine("Your Score is {0:0.00}", (count * 1.2) / 3.3);
                        Console.WriteLine("Please click enter to exit");
                        Console.Read();

                        return;
                    }
                p = rocks.Dequeue();
                Console.SetCursorPosition(p.X, p.Y);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(" ");
            }

            Thread.Sleep(time);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.RightArrow && (dwarfElements[rightElement].X) < Console.WindowWidth - 2)
                {
                    Console.SetCursorPosition(dwarfElements[rightElement].X, dwarfElements[rightElement].Y);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("-");

                    for (int i = 0; i <= 23; i++)
                    {
                        dwarfElements[i].X++;
                    }

                    Console.SetCursorPosition(dwarfElements[rightElement].X, dwarfElements[rightElement].Y);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(">");

                    Console.SetCursorPosition(dwarfElements[leftElement].X, dwarfElements[leftElement].Y);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("<");

                    Console.SetCursorPosition(dwarfElements[leftElement].X - 1, dwarfElements[leftElement].Y);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(" ");


                }

                if (pressedKey.Key == ConsoleKey.LeftArrow && dwarfElements[leftElement].X > 0)
                {
                    Console.SetCursorPosition(dwarfElements[leftElement].X, dwarfElements[leftElement].Y);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("-");

                    for (int i = 0; i <= 23; i++)
                    {
                        dwarfElements[i].X--;
                    }

                    Console.SetCursorPosition(dwarfElements[leftElement].X, dwarfElements[leftElement].Y);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("<");

                    Console.SetCursorPosition(dwarfElements[rightElement].X, dwarfElements[rightElement].Y);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(">");

                    Console.SetCursorPosition(dwarfElements[rightElement].X + 1, dwarfElements[rightElement].Y);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(" ");

                }
            }
        }
    }
}

















