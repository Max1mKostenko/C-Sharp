namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            double[,] B = new double[3, 4];

            Console.WriteLine("Enter 5 integers for array A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"A[{i}] = ");
                A[i] = int.Parse(Console.ReadLine());
            }

            Random random = new Random();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = Math.Round(random.NextDouble() * 100, 2);
                }
            }

            Console.WriteLine("\nArray A:");
            foreach (int value in A)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("\n\nArray B:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }

            double maxElement = double.MinValue;
            double minElement = double.MaxValue;

            foreach (int value in A)
            {
                if (value > maxElement) maxElement = value;
                if (value < minElement) minElement = value;
            }

            foreach (double value in B)
            {
                if (value > maxElement) maxElement = value;
                if (value < minElement) minElement = value;
            }

            double totalSum = 0;
            long totalProduct = 1;

            foreach (int value in A)
            {
                totalSum += value;
                totalProduct *= value;
            }

            foreach (long value in B)
            {
                totalSum += value;
                totalProduct *= value;
            }

            int evenSumA = 0;
            foreach (int value in A)
            {
                if (value % 2 == 0)
                {
                    evenSumA += value;
                }
            }

            double oddColumnSumB = 0;
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < B.GetLength(0); i++)
                    {
                        oddColumnSumB += B[i, j];
                    }
                }
            }

            Console.WriteLine("\nResults:");
            Console.WriteLine($"Max element: {maxElement}");
            Console.WriteLine($"Min element: {minElement}");
            Console.WriteLine($"Total sum: {totalSum}");
            Console.WriteLine($"Total product: {totalProduct}");
            Console.WriteLine($"Sum of even elements in A: {evenSumA}");
            Console.WriteLine($"Sum of odd columns in B: {oddColumnSumB}");
        }
    }
}

