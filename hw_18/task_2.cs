using System.Text.Json;

class Program
{
    static void Main()
    {
        Console.Write("Enter numbers separated by spaces: ");
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.WriteLine("Choose filter:");
        Console.WriteLine("1 - Remove prime numbers");
        Console.WriteLine("2 - Remove Fibonacci numbers");
        int choice = int.Parse(Console.ReadLine());

        numbers = choice == 1 ? RemovePrimes(numbers) : RemoveFibonacci(numbers);

        string json = JsonSerializer.Serialize(numbers, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("numbers.json", json);

        Console.WriteLine("Array saved to file.");

        string loadedJson = File.ReadAllText("numbers.json");
        int[] loadedNumbers = JsonSerializer.Deserialize<int[]>(loadedJson);

        Console.WriteLine("Loaded array: " + string.Join(" ", loadedNumbers));
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
            if (num % i == 0) return false;
        return true;
    }

    static bool IsFibonacci(int num)
    {
        int a = 0, b = 1;
        while (b < num)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b == num;
    }

    static int[] RemovePrimes(int[] arr) => arr.Where(x => !IsPrime(x)).ToArray();
    static int[] RemoveFibonacci(int[] arr) => arr.Where(x => !IsFibonacci(x)).ToArray();
}
