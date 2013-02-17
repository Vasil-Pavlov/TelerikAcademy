using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class ArithmeticExpression
{
     static List<Tuple<string, string>> Tokenize(string expression)
        {
            Regex numExpr = new Regex(@"-?\d+\.?\d*");
            Regex funcExpr = new Regex(@"ln|sqrt|pow");
            List<Tuple<string, string>> tokens = new List<Tuple<string, string>>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ' ')
                {
                    continue;
                }
                else if (expression[i] >= '0' && expression[i] <= '9' || expression[i] == '-' && tokens.Last().Item1 == ",")
                {
                    tokens.Add(new Tuple<string, string>(numExpr.Match(expression, i).Value, "num"));
                    i += tokens.Last().Item1.Length - 1;
                }
                else if (expression[i] == 'l' || expression[i] == 's' || expression[i] == 'p')
                {
                    tokens.Add(new Tuple<string, string>(funcExpr.Match(expression, i).Value, "fun"));
                    i += tokens.Last().Item1.Length - 1;
                }
                else
                {
                    switch (expression[i])
                    {
                        case '(':
                            tokens.Add(new Tuple<string, string>("(", "br1"));
                            break;
                        case ')':
                            tokens.Add(new Tuple<string, string>(")", "br2"));
                            break;
                        case '*':
                            tokens.Add(new Tuple<string, string>("*", "ope"));
                            break;
                        case '/':
                            tokens.Add(new Tuple<string, string>("/", "ope"));
                            break;
                        case '+':
                            tokens.Add(new Tuple<string, string>("+", "ope"));
                            break;
                        case '-':
                            tokens.Add(new Tuple<string, string>("-", "ope"));
                            break;
                        case ',':
                            tokens.Add(new Tuple<string, string>(",", "sep"));
                            break;
                        default:
                            Console.WriteLine("Error in Tokenize(string) method!");
                            break;
                    }
                }
            }
            return tokens;
        }

        static bool CheckPrecedence(string op1, string op2)
        {
            byte oper1 = 0;
            byte oper2 = 0;

            if (op1 == "+" || op1 == "-")
            {
                oper1 = 1;
            }

            if (op2 == "+" || op2 == "-")
            {
                oper2 = 1;
            }

            if (op1 == "*" || op1 == "/")
            {
                oper1 = 2;
            }

            if (op2 == "*" || op2 == "/")
            {
                oper2 = 2;
            }

            return oper1 <= oper2;
        }

        static string ShuntingYard(List<Tuple<string, string>> tokens)
        {
            Stack<string> operations = new Stack<string>();
            StringBuilder sb = new StringBuilder();
            const char space = ' ';

            foreach (var token in tokens)
            {
                switch (token.Item2)
                {
                    case "num":
                        {
                            sb.Append(token.Item1);
                            sb.Append(space);
                            break;
                        }
                    case "fun":
                        {
                            operations.Push(token.Item1);
                            break;
                        }
                    case "sep":
                        {
                            while (operations.Peek() != "(")
                            {
                                sb.Append(operations.Pop());
                                sb.Append(space);
                                if (operations.Count == 0)
                                {
                                    Console.WriteLine("Misplaced separator or parentheses mismatch!");
                                    break;
                                }
                            }
                            break;
                        }
                    case "ope":
                        {
                            while (operations.Count > 0 && CheckPrecedence(token.Item1, operations.Peek()))
                            {
                                sb.Append(operations.Pop());
                                sb.Append(space);
                            }

                            operations.Push(token.Item1);
                            break;
                        }
                    case "br1":
                        {
                            operations.Push(token.Item1);
                            break;
                        }
                    case "br2":
                        {
                            while (operations.Peek() != "(")
                            {
                                sb.Append(operations.Pop());
                                sb.Append(space);
                                if (operations.Count == 0)
                                {
                                    Console.WriteLine("Parentheses mismatch!");
                                    return "Parentheses mismatch!";
                                }
                            }

                            if (operations.Peek() == "(")
                            {
                                operations.Pop();
                            }
                            if (operations.Count > 0)
                            {
                                if (operations.Peek() == "ln" || operations.Peek() == "pow"
                                    || operations.Peek() == "sqrt")
                                {
                                    sb.Append(operations.Pop());
                                    sb.Append(space);
                                }
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("Error in ShuntingYard(List<Tuple<string, string>>) Method!");
                        break;
                }
            }

            while (operations.Count > 0)
            {
                if (operations.Peek() == "(")
                {
                    Console.WriteLine("Parentheses mismatch!");
                    break;
                }
                sb.Append(operations.Pop());
                sb.Append(space);
            }

            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }

        static decimal CalculateRPN(string rpn)
        {
            string[] rpnTokens = rpn.Split(' ');
            Stack<decimal> stack = new Stack<decimal>();
            decimal number = decimal.Zero;

            foreach (string token in rpnTokens)
            {

                if (decimal.TryParse(token, out number))
                {
                    stack.Push(number);
                }
                else
                {
                    switch (token)
                    {
                        case "pow":
                            {
                                number = stack.Pop();
                                stack.Push((decimal)Math.Pow((double)stack.Pop(), (double)number));
                                break;
                            }
                        case "ln":
                            {
                                stack.Push((decimal)Math.Log((double)stack.Pop(), Math.E));
                                break;
                            }
                        case "sqrt":
                            {
                                stack.Push((decimal)Math.Sqrt((double)stack.Pop()));
                                break;
                            }
                        case "*":
                            {
                                stack.Push(stack.Pop() * stack.Pop());
                                break;
                            }
                        case "/":
                            {
                                number = stack.Pop();
                                stack.Push(stack.Pop() / number);
                                break;
                            }
                        case "+":
                            {
                                stack.Push(stack.Pop() + stack.Pop());
                                break;
                            }
                        case "-":
                            {
                                number = stack.Pop();
                                stack.Push(stack.Pop() - number);
                                break;
                            }
                        default:
                            Console.WriteLine("Error in CalculateRPN(string) Method!");
                            break;
                    }
                }
            }
            return stack.Pop();
        }

        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //string expression = "(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)";
            string expression = "pow(2, 3.14 )*(3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)";
            //string expression = Console.ReadLine
            Console.WriteLine(CalculateRPN(ShuntingYard(Tokenize(expression))));
        }
    }




