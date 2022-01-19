using System;

namespace CauTruc
{
    class Program
    {
        public struct hocSinh
        {
            public string hoTen;
            public int tuoi;
            public bool gioiTinh;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            hocSinh[] arrHS = new hocSinh[n];
            for (int i = 0; i < arrHS.Length; i++)
            {
                Console.Write($"Nhap sinh vien thu {i}: ");
                Console.Write("\nNhap ten: ");
                arrHS[i].hoTen = Console.ReadLine();
                Console.Write("Nhap tuoi: ");
                arrHS[i].tuoi = int.Parse(Console.ReadLine());
                Console.Write("Nhap gioi tinh: ");
                arrHS[i].gioiTinh = Boolean.Parse(Console.ReadLine());

            }
            int sumAge = 0;
            for (int i = 0; i < arrHS.Length; i++)
            {
                sumAge += arrHS[i].tuoi;
            }
            Console.WriteLine("Tong tuoi cua cac hoc sinh la: " + sumAge);
        }
    }
}
