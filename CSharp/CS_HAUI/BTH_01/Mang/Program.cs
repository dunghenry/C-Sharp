using System;

namespace Mang
{
    class Program
    {
        static void Input(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu a[{i}] : ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static int sumle(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if(a[i] % 2 != 0)
                {
                    sum += a[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Input(a, n);
            Console.WriteLine("Tong cac phan tu le: " + sumle(a, n));
        }
    }
}
