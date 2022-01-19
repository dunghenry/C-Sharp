using System;

namespace PhuongThuc
{
    class Program
    {
        public static bool soNguyenTo(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
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
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\nNhap phan tu thu a[{i + 1}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Cac so nguyen to la: \t");
            for (int i = 0; i < n; i++)
            {
                if (soNguyenTo(a[i]))
                {
                    Console.Write($"{a[i]}\t");
                }
               
            }
        }
    }
}
