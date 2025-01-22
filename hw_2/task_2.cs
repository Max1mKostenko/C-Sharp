namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
            }

            Console.WriteLine("Array: " + string.Join(", ", array));

            int minIndex = 0, maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            if (minIndex > maxIndex)
            {
                int temp = minIndex;
                minIndex = maxIndex;
                maxIndex = temp;
            }

            int sum = 0;
            for (int i = minIndex + 1; i < maxIndex; i++)
            {
                sum += array[i];
            }

            Console.WriteLine($"Minimum element: {array[minIndex]} at index {minIndex}");
            Console.WriteLine($"Maximum element: {array[maxIndex]} at index {maxIndex}");
            Console.WriteLine($"Sum of elements between minimum and maximum: {sum}");
        }
    }
}


