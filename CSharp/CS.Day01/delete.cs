using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp
{
    class delete
    {
        static void Main()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[10];
            //Nhập mảng 

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            //Nhập vt trị cần xóa
         
            Console.Write("Nhap vi tri can xoa: ");
            int vt = int.Parse(Console.ReadLine());

            for (int i = vt; i < n ; i++)
            {
                a[i] = a[i + 1];
            }
            n--;
            Console.Write("\nXuat mang: \t");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "\t");
            }
        }
    }
}
