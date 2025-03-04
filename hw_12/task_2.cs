namespace ConsoleApp16
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 5, 8, 12, 15, 20, 25, 30 };
            int minRange = 10;
            int maxRange = 20;

            Predicate<int> isInRange = n => (n >= minRange && n <= maxRange);
            int count = numbers.Count(n => isInRange(n));

            Console.WriteLine($"Count of numbers in range [{minRange}, {maxRange}]: {count}");
        }
    }
}

