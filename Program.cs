using System;
internal class Program
{
    private static int Fibonacci(int n)
    {
        if (n == 0) return 0;

        else if (n == 1) return 1;

        else if (n < 10) return Fibonacci(n - 1) + Fibonacci(n - 2);

        else return 0; // dla n >= 10
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("First 10 numbers of the Fibonacci sequence:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}