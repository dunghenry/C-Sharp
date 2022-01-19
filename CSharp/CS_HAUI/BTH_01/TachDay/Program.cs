using System;

namespace TachDay
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
        static void chan(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write($"{a[i]} \t");
                }
            }
        }
        static void le(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 1)
                {
                    Console.Write($"{a[i]} \t");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Input(a, n);
            Console.Write("Xuat mang chan: \t");
            chan(a, n);
            Console.Write("\nXuat mang le: \t");
            le(a, n);
        }
    }
}
