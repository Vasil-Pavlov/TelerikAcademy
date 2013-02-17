using System;
using System.Text;
using System.Collections.Generic;

class CorrectBrackets
{
    static void Main()
    {
        string expression =Console.ReadLine();
        bool isCorrect = true;
        Queue<char> brackets = new Queue<char>();

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                brackets.Enqueue(expression[i]);
            }
            if (expression[i] == ')')
            {
                if (brackets.Count > 0)
                {
                    brackets.Dequeue();
                }
                else
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        if (brackets.Count != 0)
        {
            isCorrect = false;
        }
        if (isCorrect == true)
        {
            Console.WriteLine("Correct Brackets!");
        }
        else
        {
            Console.WriteLine("Incorrect Brackets!");
        }
    }
}

