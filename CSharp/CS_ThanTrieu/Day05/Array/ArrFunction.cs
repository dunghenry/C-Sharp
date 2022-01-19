using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class ArrFunction
    {
        static void Input(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu a[{i}] : ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Output(int[] a, int n)
        {
            Console.Write("Xuat mang: \t");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "\t");
            }
            
        }
        static void Sort(int[] a, int n)
        {
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(a[i] > a[j])
                    {
                        int tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }
        }
        static void SortOne(int[] a, int n)
        {

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        int tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }
        }
        static void Delete(int[] a, int n, int vt)
        {
            for (int i = vt; i < n - 1; i++) {
                a[i] = a[i + 1];
            }
           
        }
        public static void Insert(int[] a, int n, int vt1, int x)
        {
           
        }
        static void Main()
        {
            Console.Write("Nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Input(a, n);
            Console.WriteLine("Sap xep tang dan: ");
            Sort(a, n);
            Output(a, n);
            Console.WriteLine("\nSap xep giam dan: ");
            SortOne(a, n);
            Output(a, n);
            Console.Write("\nNhap vi tri can xoa: ");
            int vt = int.Parse(Console.ReadLine());
            Console.WriteLine("Xuat mang delete: ");
            Delete(a, n, vt);
            Output(a, n-1);
        }
    }
}
