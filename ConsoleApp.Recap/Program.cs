using System;

namespace ConsoleApp.Recap
{
    public  class Program
    {
        static void Main()
        {
            PrintNumbers(1, 2, 3, 4,5);
        }
        public static void PrintNumbers(params int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
