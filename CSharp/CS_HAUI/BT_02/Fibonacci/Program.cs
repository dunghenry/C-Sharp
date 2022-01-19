using System;

namespace Fibonacci
{
    class Program
    {
        static int fibonacci(int n)
        {
            int first = 0;
            int second = 1;
            int number = default;
            for (int i = 0; i < n; i++)
            {
                if (n <= 1)
                {
                    number = n;
                }
                else
                {
                   
                    first = second;
                    second = number;
                    number = first + second;
                }         
            }
            return number;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(fibonacci(i));
            }
        }
    }
}
