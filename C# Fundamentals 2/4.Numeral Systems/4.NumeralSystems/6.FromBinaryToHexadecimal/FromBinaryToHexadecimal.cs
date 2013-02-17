using System;

class FromBinaryToHexadecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        int count = 1;
        string currentValue = "";
        int presentValue = 0;
        string hexadecimalNumber = "";
        int first = binaryNumber.Length % 4;

        for (int i = 0; i < first; i++)
        {
            currentValue = currentValue + binaryNumber[i].ToString();
        }
        for (int i = 0; i < currentValue.Length; i++)
        {
            presentValue = presentValue + (int.Parse(currentValue[i].ToString())) * (int)(Math.Pow(2, currentValue.Length - i - 1));
        }
        switch (presentValue)
        {
            case 0:
                hexadecimalNumber = hexadecimalNumber + "0";
                break;
            case 1:
                hexadecimalNumber = hexadecimalNumber + "1";
                break;
            case 2:
                hexadecimalNumber = hexadecimalNumber + "2";
                break;
            case 3:
                hexadecimalNumber = hexadecimalNumber + "3";
                break;
            case 4:
                hexadecimalNumber = hexadecimalNumber + "4";
                break;
            case 5:
                hexadecimalNumber = hexadecimalNumber + "5";
                break;
            case 6:
                hexadecimalNumber = hexadecimalNumber + "6";
                break;
            case 7:
                hexadecimalNumber = hexadecimalNumber + "7";
                break;
            case 8:
                hexadecimalNumber = hexadecimalNumber + "8";
                break;
            case 9:
                hexadecimalNumber = hexadecimalNumber + "9";
                break;
            case 10:
                hexadecimalNumber = hexadecimalNumber + "A";
                break;
            case 11:
                hexadecimalNumber = hexadecimalNumber + "B";
                break;
            case 12:
                hexadecimalNumber = hexadecimalNumber + "C";
                break;
            case 13:
                hexadecimalNumber = hexadecimalNumber + "D";
                break;
            case 14:
                hexadecimalNumber = hexadecimalNumber + "E";
                break;
            case 15:
                hexadecimalNumber = hexadecimalNumber + "F";
                break;
        }
        currentValue = "";

        for (int i = first; i < binaryNumber.Length; i++)
        {
            currentValue = currentValue + binaryNumber[i].ToString();
            if (count % 4 == 0)
            {
                presentValue = 0;
                for (int j = 0; j < currentValue.Length; j++)
                {
                    presentValue = presentValue + (int.Parse(currentValue[j].ToString())) * (int)(Math.Pow(2, currentValue.Length - j - 1));
                }
                switch (presentValue)
                {
                    case 0:
                        hexadecimalNumber = hexadecimalNumber + "0";
                        break;
                    case 1:
                        hexadecimalNumber = hexadecimalNumber + "1";
                        break;
                    case 2:
                        hexadecimalNumber = hexadecimalNumber + "2";
                        break;
                    case 3:
                        hexadecimalNumber = hexadecimalNumber + "3";
                        break;
                    case 4:
                        hexadecimalNumber = hexadecimalNumber + "4";
                        break;
                    case 5:
                        hexadecimalNumber = hexadecimalNumber + "5";
                        break;
                    case 6:
                        hexadecimalNumber = hexadecimalNumber + "6";
                        break;
                    case 7:
                        hexadecimalNumber = hexadecimalNumber + "7";
                        break;
                    case 8:
                        hexadecimalNumber = hexadecimalNumber + "8";
                        break;
                    case 9:
                        hexadecimalNumber = hexadecimalNumber + "9";
                        break;
                    case 10:
                        hexadecimalNumber = hexadecimalNumber + "A";
                        break;
                    case 11:
                        hexadecimalNumber = hexadecimalNumber + "B";
                        break;
                    case 12:
                        hexadecimalNumber = hexadecimalNumber + "C";
                        break;
                    case 13:
                        hexadecimalNumber = hexadecimalNumber + "D";
                        break;
                    case 14:
                        hexadecimalNumber = hexadecimalNumber + "E";
                        break;
                    case 15:
                        hexadecimalNumber = hexadecimalNumber + "F";
                        break;
                }
                currentValue = "";
            }
            count++;
        }
        Console.WriteLine(hexadecimalNumber);
    }
}

