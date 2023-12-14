using System;
using System.Threading;

namespace MultithreadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(PrintNumbers);
            Thread thread2 = new Thread(PrintNumbers);
            Thread thread3 = new Thread(PrintNumbers);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();
        }
        static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
