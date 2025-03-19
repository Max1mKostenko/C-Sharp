using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var filteredNumbers = FilterByTwoCriteria(numbers, x => x % 2 == 0, x => x > 5);
        Console.WriteLine("Filtered numbers: " + string.Join(", ", filteredNumbers));

        List<string> words = new List<string> { "apple", "banana", "cherry", "date", "fig", "grape" };
        var filteredWords = FilterByTwoCriteria(words, w => w.Length > 4, w => w.Contains("a"));
        Console.WriteLine("Filtered words: " + string.Join(", ", filteredWords));
    }

    static List<T> FilterByTwoCriteria<T>(IEnumerable<T> collection, Predicate<T> criteria1, Predicate<T> criteria2)
    {
        return collection.Where(item => criteria1(item) && criteria2(item)).ToList();
    }
}
