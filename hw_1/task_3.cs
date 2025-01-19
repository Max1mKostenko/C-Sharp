using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Num1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Num2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Num3: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Num4: ");
            int num4 = int.Parse(Console.ReadLine());

            Console.Write(num1 * 1000 + num2 * 100 + num3 * 10 + num4);
        }
    }
}
