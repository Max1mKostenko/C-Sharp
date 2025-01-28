namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();

            string result = "";
            bool capitalizeNext = true;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (capitalizeNext && char.IsLetter(currentChar))
                {
                    result += char.ToUpper(currentChar);
                    capitalizeNext = false;
                }
                else
                {
                    result += currentChar;
                }

                if (currentChar == '.' || currentChar == '!' || currentChar == '?')
                {
                    capitalizeNext = true;
                }
            }

            Console.WriteLine("Result:");
            Console.WriteLine(result);
        }
    }
}
