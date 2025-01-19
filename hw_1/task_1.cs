using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Num: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 100)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.Write("Fizz Buzz");
                }
                else if (num % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else
                {
                    Console.Write(num);
                }
            }
            else
            {
                Console.Write("Number isn't in range");
            }
        }
    }
}
