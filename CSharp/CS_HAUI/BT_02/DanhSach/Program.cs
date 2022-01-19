using System;
using System.Collections.Generic;
namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dsThanhPho = thanhPho.ThanhPho();
            dsThanhPho.Sort();
            foreach (var item in dsThanhPho)
            {
                Console.WriteLine(item);
            }
            dsThanhPho.Remove("Ha Noi");
        }
        class thanhPho
        {
            public static List<string> ThanhPho()
            {
                List<string> dsThanhPho = new List<string>();
                string luachon = "";
                while(luachon != "N")
                {
                    Console.Write("\nNhap vao ten mot thanh pho: ");
                    dsThanhPho.Add(Console.ReadLine());
                    Console.WriteLine("\nNhap n de ket thuc!");
                    luachon = Console.ReadLine().ToUpper();
                }
                return dsThanhPho;
            }
        }

       
    }
}
