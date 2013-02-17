using System;

class BonusScores
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine("{0}",number*10);
                break;
            case 2:
                Console.WriteLine("{0}", number * 10);
                break;
            case 3:
                Console.WriteLine("{0}", number * 10);
                break;
            case 4:
                Console.WriteLine("{0}", number * 100);
                break;
            case 5:
                Console.WriteLine("{0}", number * 100);
                break;
            case 6:
                Console.WriteLine("{0}", number * 100);
                break;
            case 7:
                Console.WriteLine("{0}", number * 1000);
                break;
            case 8:
                Console.WriteLine("{0}", number * 1000);
                break;
            case 9:
                Console.WriteLine("{0}", number * 1000);
                break;
            default:
                Console.WriteLine("The number is not in the range!");
                break;
        }
    }
}

