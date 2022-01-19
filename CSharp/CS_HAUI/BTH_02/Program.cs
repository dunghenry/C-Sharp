using System;

namespace BTH_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n tu ban phim: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n ; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"{i}: la so chan");
                }
                else
                {
                    Console.WriteLine($"{i}: la so le");
                }
            }
        }
    }
}
