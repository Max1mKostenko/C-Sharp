namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an arithmetic expression with + and -:");
            string expression = Console.ReadLine();

            double result = 0;
            int sign = 1;
            string currentNumber = "";

            for (int i = 0; i < expression.Length; i++)
            {
                char symbol = expression[i];

                if (symbol == '+' || symbol == '-')
                {
                    if (currentNumber != "")
                    {
                        result += sign * double.Parse(currentNumber);
                        currentNumber = "";
                    }

                    sign = (symbol == '+') ? 1 : -1;
                }
                else if (char.IsDigit(symbol) || symbol == '.')
                {
                    currentNumber += symbol;
                }
                else if (symbol != ' ')
                {
                    Console.WriteLine("Invalid character in the expression.");
                    return;
                }
            }

            if (currentNumber != "")
            {
                result += sign * double.Parse(currentNumber);
            }

            Console.WriteLine("Result: " + result);
        }
    }
}


