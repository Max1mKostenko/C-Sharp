using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Num: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("percent: ");
            int percent = int.Parse(Console.ReadLine());

            Console.Write($"{percent}% of {num1} = {num1 * percent/100}");
        }
    }
}
