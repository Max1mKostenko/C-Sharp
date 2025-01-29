namespace ConsoleApp7
{
    internal class Program
    {
        static bool IsPalindrome(int number)
        {
            string str = number.ToString();
            int length = str.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            Console.WriteLine(IsPalindrome(1221));
            Console.WriteLine(IsPalindrome(3443));
            Console.WriteLine(IsPalindrome(7854));
        }
    }
}

