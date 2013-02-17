using System;

class PrimeNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
        {
            Console.WriteLine("{0} is prime.", number);
        }
        else
        {
            Console.WriteLine("{0} is not prime.", number);
        }
    }
}
