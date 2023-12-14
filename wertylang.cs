using System;
using System.Threading;
namespace AsyncFactorialExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¬ведите число:");
            int number = int.Parse(Console.ReadLine());
            Task<int> factorialTask = CalculateFactorialAsync(number);
            int square = CalculateSquare(number);
            factorialTask.Wait();
            Console.WriteLine("‘акториал числа {0}: {1}", number, factorialTask.Result);
            Console.WriteLine(" вадрат числа {0}: {1}", number, square);
        }
        static async Task<int> CalculateFactorialAsync(int number)
        {
            await Task.Delay(8000);
            int factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static int CalculateSquare(int number)
        {
            return number * number;
        }
    }
}