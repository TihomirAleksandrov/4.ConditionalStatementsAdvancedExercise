using System;

namespace OperationBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = 0;

            if (operation == "+")
            {
                result = number1 + number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} + {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} + {number2} = {result} - odd");
                }
            }
            else if (operation == "-")
            {
                result = number1 - number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} - {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} - {number2} = {result} - odd");
                }
            }
            else if (operation == "*")
            {
                result = number1 * number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} * {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} * {number2} = {result} - odd");
                }
            }
            else if (operation == "/")
            {
                result = number1 / number2;

                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    Console.WriteLine($"{number1} / {number2} = {result:f2}");
                }
            }
            else if (operation == "%")
            {
                result = number1 % number2;

                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    Console.WriteLine($"{number1} % {number2} = {result}");
                }
            }

        }
    }
}
