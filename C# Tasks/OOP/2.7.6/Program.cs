namespace _2._7._6
{
    internal class Program
    {
        private static double Calculate(double a, double b, char c)
        {
            if (c == '+')
            {
                return a + b;
            }
            else if (c == '-')
            {
                return a - b;
            }
            else if (c == '*')
            {
                return a * b;
            }
            else if (c == '/')
            {
                return a / b;
            }
            return 0;
        }

        private static void Calc()
        {
            double b = numbers.Pop();

            double a = numbers.Pop();

            char sign = operands.Pop();

            ans = ans + sign + ' ';

            numbers.Push(Calculate(a, b, sign));
        }

        private static int Priority(char c)
        {
            if (c == '(')
            {
                return 0;
            }
            else if (c == '+' || c == '-')
            {
                return 1;
            }
            else if (c == '*' || c == '/')
            {
                return 2;
            }
            return 3;
        }

        static Stack<char> operands = new Stack<char>();
        static Stack<double> numbers = new Stack<double>();
        static string ans = "";
        static void Main(string[] args)
        {
            string expression = Console.ReadLine()!;

            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsDigit(expression[i]))
                {
                    ans = ans + (expression[i] - '0') + ' ';
                    numbers.Push(expression[i] - '0');
                }
                else
                {
                    if (expression[i] == '(')
                    {
                        operands.Push(expression[i]);
                    }
                    else
                    {
                        if (expression[i] == ')')
                        {
                            while (operands.Peek() != '(')
                            {
                                Calc();
                                operands.Pop();
                            }
                        }
                        else
                        {
                            while (operands.Count > 0 && Priority(expression[i])<Priority(operands.Peek()))
                            {
                                Calc();
                            }
                            operands.Push(expression[i]);
                        }
                    }
                }
            }
            while (operands.Count > 0)
            {
                Calc();
            }
            Console.WriteLine(ans);
            Console.WriteLine(numbers.Peek());
        }
    }
}