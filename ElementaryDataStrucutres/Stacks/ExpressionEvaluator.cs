using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryDataStrucutres.Stacks
{
    class ExpressionEvaluator
    {
        public static bool BalancedParentheses(string expression)
        {
            char[] tokens = expression.ToCharArray();
            Stack<char> brackets = new Stack<char>();
            foreach (char token in tokens)
            {
                if (token == '(')
                    brackets.Push(token);


                if (!brackets.IsEmpty() && token == ')')
                    brackets.Pop();
                else
                    break;
            }

            return brackets.IsEmpty() ? true : false;
        }

        private static bool IsOperator(string token)
        {
            bool isOp = false;
            switch (token)
            {
                case "+":
                    isOp = true;
                    break;
                case "-":
                    isOp = true;
                    break;
                case "*":
                    isOp = true;
                    break;
                case "/":
                    isOp = true;
                    break;
                case "(":
                    isOp = true;
                    break;
                case ")":
                    isOp = true;
                    break;
                default:
                    break;
            }

            return isOp;
        }

        private static int Calculate(string token, int a, int b)
        {
            int result = 0;
            switch (token)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                default:
                    break;
            }

            return result;
        }

        public static float Evaluate(string expression)
        {
            float result = 0.0f;
            int scan = 0;
            string[] tokens = expression.Split(' ');
            Stack<string> operatorStack = new Stack<string>();
            Stack<int> operandStack = new Stack<int>();
            string token = string.Empty;
            while (scan < tokens.Length)
            {
                token = tokens[scan];
                if (token == "(")
                {
                    operatorStack.Push(token);
                }

                if (!IsOperator(token))
                    operandStack.Push(Convert.ToInt32(token));
                else if(token != "(" && token != ")")
                    operatorStack.Push(token);

                if (token == ")")
                {
                    while (operatorStack.Peek() != "(")
                    {
                        int a = operandStack.Pop();
                        int b = operandStack.Pop();
                        operandStack.Push(Calculate(operatorStack.Pop(), a, b));
                    }

                    operatorStack.Pop();
                }
                else
                {
                    while (!operatorStack.IsEmpty())
                    {
                        int a = operandStack.Pop();
                        int b = operandStack.Pop();
                        operandStack.Push(Calculate(operatorStack.Pop(), a, b));
                    }
                }

                scan++;
            }

            return operandStack.Peek();
        }
    }
}
