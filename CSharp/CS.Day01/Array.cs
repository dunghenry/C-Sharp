using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp
{
    class Array
    {
        static void Main()
        {
            Console.Write("Nhap so phan tu cua mang lon hon: ");
            int n = int.Parse(Console.ReadLine());
            while(n <= 0)
            {
                Console.Write("Nhap lai so phan tu cua mang lon hon 0: ");
                n = int.Parse(Console.ReadLine());
            }
            int[] diemTb = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu a[{i}] : ");
                diemTb[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nXuat mang: \t");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{diemTb[i]} \t");
            }
            Console.WriteLine();
            Console.WriteLine(diemTb.Length);
            Console.WriteLine();
            Console.WriteLine(diemTb.Rank);
            Console.WriteLine();
            Console.WriteLine(diemTb.Max());
            Console.WriteLine();
            Console.WriteLine(diemTb.Min());
            Console.WriteLine();
            Console.WriteLine(diemTb.Sum());
            
        }
    }
}
