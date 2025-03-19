using System;
using System.Linq;

interface ICalc2
{
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}

class ArrayClass : ICalc2
{
    private int[] array;

    public ArrayClass(int[] arr)
    {
        array = arr;
    }

    public int CountDistinct()
    {
        return array.Distinct().Count();
    }

    public int EqualToValue(int valueToCompare)
    {
        return array.Count(x => x == valueToCompare);
    }
}

class Program
{
    static void Main()
    {
        int[] data = { 1, 2, 2, 3, 4, 4, 4, 5 };
        ArrayClass arrayObj = new ArrayClass(data);

        Console.WriteLine("Distinct count: " + arrayObj.CountDistinct());
        Console.WriteLine("Equal to 4: " + arrayObj.EqualToValue(4));
    }
}
