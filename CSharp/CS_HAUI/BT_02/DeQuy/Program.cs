using System;

namespace DeQuy
{
    class Program
    {
        static int giaiThua(int n)
        {
            if(n <= 0)
            {
                return 0;
            }
            else
            {
                return n * giaiThua(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Giai thua la: " + giaiThua(n));
        }
    }
}
