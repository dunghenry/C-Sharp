using System;

namespace LearnLoopControls
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                sum += i;
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
