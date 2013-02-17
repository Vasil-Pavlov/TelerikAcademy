using System;

class PronounceNumbersInEnglish
{
    public static void ShowNumber(int number)
    {
        switch (number)
        {
            case 0:
                Console.Write(" zero ");
                break;
            case 1:
                Console.Write(" one ");
                break;
            case 2:
                Console.Write(" two");
                break;
            case 3:
                Console.Write(" three");
                break;
            case 4:
                Console.Write(" four");
                break;
            case 5:
                Console.Write(" five");
                break;
            case 6:
                Console.Write(" six");
                break;
            case 7:
                Console.Write(" seven ");
                break;
            case 8:
                Console.Write(" eight ");
                break;
            case 9:
                Console.Write(" nine ");
                break;
            case 10:
                Console.Write(" ten ");
                break;
            case 11:
                Console.Write(" eleven ");
                break;
            case 12:
                Console.Write(" twelve ");
                break;
            case 13:
                Console.Write(" thirteen ");
                break;
            case 14:
                Console.Write(" fourteen ");
                break;
            case 15:
                Console.Write(" fifteen ");
                break;
            case 17:
                Console.Write(" seventeen ");
                break;
            case 18:
                Console.Write(" eighteen ");
                break;
            case 19:
                Console.Write(" nineteen ");
                break;
            case 20:
                Console.Write(" twenty ");
                break;
            case 30:
                Console.Write(" thirty ");
                break;
            case 40:
                Console.Write(" forty ");
                break;
            case 50:
                Console.Write(" fifty ");
                break;
            case 60:
                Console.Write(" sixty ");
                break;
            case 70:
                Console.Write(" seventy ");
                break;
            case 80:
                Console.Write(" eighty ");
                break;
            case 90:
                Console.Write(" ninety ");
                break;
            case 100:
                Console.Write(" hundred ");
                break;
            default:
                Console.WriteLine("The number {0} is not in the range!", number);
                break;
        }
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int units = number % 10;
        int decimals = (number / 10) % 10;
        int hundreds = number / 100;

        if (number >= 0 && number <= 999)
        {

            if (hundreds > 1)
            {
                if (decimals == 0 || units == 0)
                {
                    ShowNumber(hundreds);
                    Console.Write(" hundred ");
                    if (units > 0)
                    {
                        Console.Write(" and ");
                        ShowNumber(units);
                    }
                    if (units == 0 && decimals != 0)
                    {
                        Console.Write(" and ");
                        ShowNumber((decimals * 10) + units);
                    }
                }
                else
                {
                    ShowNumber(hundreds);
                    Console.Write(" hundred ");
                    Console.Write(" and ");

                    if (decimals == 1)
                    {
                        ShowNumber(decimals * 10 + units);
                        return;
                    }
                    if (decimals > 0)
                    {
                        ShowNumber((decimals * 10));
                        ShowNumber(units);
                    }
                    else
                    {
                        ShowNumber(units);
                    }
                }
            }

            else if (hundreds == 1)
            {
                if (decimals == 0 || units == 0)
                {
                    ShowNumber(hundreds);
                    ShowNumber(number - ((decimals * 10) + units));
                    if (units > 0)
                    {
                        Console.Write(" and ");
                        ShowNumber(units);
                    }
                    if (units==0 && decimals!=0)
                    {
                        Console.Write(" and ");
                        ShowNumber((decimals*10)+units);
                    }
                }
                else
                {
                    ShowNumber(hundreds);
                    ShowNumber(number - ((decimals * 10) + units));
                    Console.Write(" and ");
                    if (decimals==1)
                    {
                        ShowNumber(decimals*10+units);
                        return;
                    }
                    if (decimals > 0)
                    {
                        ShowNumber((decimals * 10));
                        ShowNumber(units);
                    }
                    else
                    {
                        ShowNumber(units);
                    }
                }
            }

            else if (decimals > 1)
            {
                ShowNumber(number - units);

                if (units > 0)
                {
                    ShowNumber(units);
                }
            }

            else
            {
                ShowNumber(number);
            }
        }
        Console.WriteLine();
    }
}


