using System;

class SimpleNumbersMatrix
{
    static void Main()
    {
        int numberOfMatrixElements = int.Parse(Console.ReadLine());  
        int [,] matrix=new int [numberOfMatrixElements,numberOfMatrixElements];
        int currentNumber = 0;
        int count = 1;

        for (int column = 0; column < numberOfMatrixElements; column++)
        {
            currentNumber = column;

            for (int row = 0; row <= currentNumber; row++)
            {
                matrix[row, column] = count;
                column--;
            }
            column = currentNumber;
            count++;
        }

        for (int column = 1; column < numberOfMatrixElements; column++)
        {
            currentNumber = column;

            for (int row = numberOfMatrixElements-1; row >= currentNumber; row--)
            {
                matrix[column, row] = count;
                column++;
            }
            column = currentNumber;
            count++;
        }

        for (int column = 0; column < numberOfMatrixElements; column++)
        {
            for (int row = 0; row <numberOfMatrixElements; row++)
            {
                Console.Write("{0} ",matrix[column,row]);
            }
            Console.WriteLine();
        }
    }
}

