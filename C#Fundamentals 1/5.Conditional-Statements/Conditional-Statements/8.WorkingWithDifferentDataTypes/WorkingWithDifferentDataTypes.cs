using System;

class WorkingWithDifferentDataTypes
{
    static void Main()
    {
        byte choice=Byte.Parse(Console.ReadLine());
        int integerInput;
        string stringInput;
        double doubleInput;

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter an integer:");
                integerInput = int.Parse(Console.ReadLine());
                Console.WriteLine(++integerInput);
                break;
            case 2:
                Console.WriteLine("Enter a real number:");
                doubleInput = double.Parse(Console.ReadLine());
                Console.WriteLine(++doubleInput);
                break;
            case 3:
                Console.WriteLine("Enter a string:");
                stringInput = Console.ReadLine();
                Console.WriteLine(stringInput + "*");
                break;
            default:
                Console.WriteLine("Invalid choice of data type!");
                break;
        }
    }
}

