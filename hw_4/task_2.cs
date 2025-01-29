namespace ConsoleApp7
{
    internal class Program
    {
        static int[] FilterArray(int[] original_array, int[] filter_array)
        {
            int[] result = new int[original_array.Length];
            int index = 0;

            foreach (int num in original_array)
            {
                bool found = false;
                foreach (int filter in filter_array)
                {
                    if (num == filter)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    result[index++] = num;
                }
            }

            Array.Resize(ref result, index);
            return result;
        }

        static void Main()
        {
            int[] original_array = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filter_array = { 6, 88, 7 };

            Console.WriteLine(string.Join(" ", FilterArray(original_array, filter_array)));
        }
    }
}

