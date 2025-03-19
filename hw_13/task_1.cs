interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

class ArrayClass : ICalc
{
    private int[] numbers;

    public ArrayClass(int[] numbers)
    {
        this.numbers = numbers;
    }

    public int Less(int valueToCompare)
    {
        int count = 0;
        foreach (int num in numbers)
        {
            if (num < valueToCompare)
                count++;
        }
        return count;
    }

    public int Greater(int valueToCompare)
    {
        int count = 0;
        foreach (int num in numbers)
        {
            if (num > valueToCompare)
                count++;
        }
        return count;
    }
}

class Program
{
    static void Main()
    {
        int[] testArray = { 1, 5, 8, 10, 3, 7, 6 };
        ArrayClass arrayObj = new ArrayClass(testArray);

        int valueToCompare = 5;
        Console.WriteLine($"Count of numbers less than {valueToCompare}: {arrayObj.Less(valueToCompare)}");
        Console.WriteLine($"Count of numbers greater than {valueToCompare}: {arrayObj.Greater(valueToCompare)}");
    }
}
