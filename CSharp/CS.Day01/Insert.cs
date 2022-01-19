using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp
{
    class Insert
    {
        static void Main()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            //Nhập mảng 
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            //Nhập giá trị cần chèn và vị trí cần chèn
            Console.Write("Nhap gia tri can chen: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap vi tri can chen: ");
            int vt = int.Parse(Console.ReadLine());
            //Tạo mảng mới để lưu mảng sau khi chèn
            int[] anew = new int[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                if(i < vt)
                {
                    anew[i] = a[i];
                }
                else if(i == vt){
                    anew[i] = x;
                }
                else
                {
                    anew[i] = a[i - 1];
                }

            }
            Console.Write("\nXuat mang: \t");
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write(anew[i] + "\t");
            }
        }
    }
}
