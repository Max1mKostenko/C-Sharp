namespace ConsoleApp16
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { -5, -10, 3, -5, 7, -10, -1, 4, -3, -1, -8 };

            Predicate<int> uniqueNegative = x => x < 0 && numbers.Count(n => n == x) == 1;

            int[] negatives = Array.FindAll(numbers, uniqueNegative);

            Console.WriteLine(string.Join(" ", negatives));
        }
    }
}
