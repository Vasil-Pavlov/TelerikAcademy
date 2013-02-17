using System;

class ShowAStandardDeckOfCards
{
    static void ShowCardName(int number)
    {
        switch (number)
        {
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            case 10:
                Console.WriteLine("Ten");
                break;
            case 11:
                Console.WriteLine("Jack");
                break;
            case 12:
                Console.WriteLine("Queen");
                break;
            case 13:
                Console.WriteLine("King");
                break;
            case 14:
                Console.WriteLine("Ace");
                break;
            default:
                Console.WriteLine("Invalid number of a card!");
                break;
        }
    }

    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            ShowCardName(i);
            Console.WriteLine("Club");
            ShowCardName(i);
            Console.WriteLine("Diamond");
            ShowCardName(i);
            Console.WriteLine("Heart");
            ShowCardName(i);
            Console.WriteLine("Spade");
        }
    }
}

