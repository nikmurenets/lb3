using System;

using System.Collections.Generic;

using System.Linq;



namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            bool f = false;

            try
            {
                switch (f)
                {
                    case false:
                        {
                            Console.WriteLine("Введите первое число, затем операцию (+,-,*,/) и после - второе число. Пример: 10+15");
                            string readline = Console.ReadLine();

                            double x = Double.Parse(string.Concat(readline.TakeWhile(char.IsDigit)));

                            char op = readline.First(x => x.Equals('*') || x.Equals('/') || x.Equals('+') || x.Equals('-'));

                            int IndexOp = readline.IndexOf(op);

                            string lineafterop1 = readline.Substring(IndexOp + 1);

                            int indexDigitsAfterOp = lineafterop1.IndexOfAny(digits);

                            string digitsAfterOp = lineafterop1.Substring(indexDigitsAfterOp);

                            double y = Double.Parse(string.Concat(digitsAfterOp.TakeWhile(char.IsDigit)));

                            Calculator calculator = new Calculator(x, y, op);

                            goto case false;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class Calculator
    {
        double x;
        double y;

        public Calculator(double X, double Y, char op)
        {
            x = X;
            y = Y;

            if (op == '+') Addition();
            else if (op == '-') Substraction();
            else if (op == '*') Multiplication();
            else if (op == '/') Division();
        }

        public void Addition()
        {
            Console.WriteLine(x + y);
        }
        public void Substraction()
        {
            Console.WriteLine(x - y);
        }

        public void Multiplication()
        {
            Console.WriteLine(x * y);
        }

        public void Division()
        {
            Console.WriteLine(x / y);
        }
    }
}