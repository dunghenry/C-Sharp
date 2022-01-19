using System;

namespace Bai2
{
    class Program
    {
        static void Input(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu a[{i}]:  ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static int max(int[] a, int n)
        {
            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                if(a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        static int min(int[] a, int n)
        {
            int min = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        static int sum(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        static void Output(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]}\t");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Input(a, n);
            Console.Write("Xuat mang: \t");
            Output(a, n);
            Console.Write("\nMax la: " + max(a, n));
            Console.Write("\nMin la: " + min(a, n));
            Console.Write("\nSum la: " + sum(a, n));
        }
    }
}
