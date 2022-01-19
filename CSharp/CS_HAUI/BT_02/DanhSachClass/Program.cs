using System;

namespace DanhSachClass
{
    class Program
    {
        static void Input(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());

            }
        }
        static void soChan(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if(a[i] % 2 == 0)
                {
                    Console.Write($"{a[i]}\t");
                }
            }
        }
        static void soLe(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                {
                    Console.Write($"{a[i]}\t");
                }
            }
        }
        static bool soNguyenTo(int n)
        {
            if(n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                  if(n % i == 0)
                   {
                    return false;
                  }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Input(a, n);
            Console.Write("So chan la:\t");
            soChan(a, n);
            Console.Write("\nSo le la:\t");
            soLe(a, n);
            Console.Write("\nSo nguyen to:\t");
            for(int i = 0; i < n; i++)
            {
                if (soNguyenTo(a[i]))
                {
                    Console.Write($"{a[i]}\t");
                } 
            }
        }
    }
}
