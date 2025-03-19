interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}

class ArrayClass : IOutput2
{
    private int[] array;

    public ArrayClass(int[] arr)
    {
        array = arr;
    }

    public void ShowEven()
    {
        Console.Write("Even numbers: ");
        foreach (int num in array)
        {
            if (num % 2 == 0)
                Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public void ShowOdd()
    {
        Console.Write("Odd numbers: ");
        foreach (int num in array)
        {
            if (num % 2 != 0)
                Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        ArrayClass arrayObj = new ArrayClass(data);

        arrayObj.ShowEven();
        arrayObj.ShowOdd();
    }
}
