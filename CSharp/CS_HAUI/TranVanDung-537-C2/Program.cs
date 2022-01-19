using System;
using System.Collections.Generic;
namespace TranVanDung_537_C2
{
    class Program
    {
        static private List<Nguoi> dsNguoi = new List<Nguoi>();

        static void Main(string[] args)
        {
            Nhap();
            Console.WriteLine("\n{0,-20}{1,-10}{2,-10}{3,-20}{4,-20}{5,-10}{6,-10}", "HoTen", "GioiTinh", "Tuoi", "DiaChi", "TenCongTy", "NgayVao", "HeSoLuong");
            XuatDanhSachNguoi();
            Console.ReadLine();
        }
        static private void Nhap()
        {
            string hoten, gioitinh, diachi, tencongty, ngayvao;
            int tuoi;
            double hesoluong;
            Console.WriteLine("\n1. Nhap thong tin nguoi: ");
            Console.WriteLine("\n2. Nhap thong tin cong nhan: ");
            Console.Write("\nNhap vao lua chon cua ban: ");
            string luachon = Console.ReadLine();
            switch (luachon)
            {
                case "1":
                    Console.WriteLine("\nNhap ho ten: ");
                    hoten = Console.ReadLine();
                    Console.WriteLine("\nNhap gioi tinh: ");
                    gioitinh = Console.ReadLine();
                    Console.WriteLine("\nNhap tuoi: ");
                    tuoi = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nNhap dia chi: ");
                    diachi = Console.ReadLine();
                    Nguoi nguoimoi = new Nguoi(hoten, gioitinh, tuoi, diachi);
                    dsNguoi.Add(nguoimoi);
                    break;
                case "2":
                    Console.WriteLine("\nNhap ho ten: ");
                    hoten = Console.ReadLine();
                    Console.WriteLine("\nNhap gioi tinh: ");
                    gioitinh = Console.ReadLine();
                    Console.WriteLine("\nNhap tuoi: ");
                    tuoi = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nNhap dia chi: ");
                    diachi = Console.ReadLine();
                    Console.WriteLine("\nNhap ten cong ty: ");
                    tencongty = Console.ReadLine();
                    Console.WriteLine("\nNhap ngay vap: ");
                    ngayvao = Console.ReadLine();
                    Console.WriteLine("\nNhap he so luong: ");
                    hesoluong = double.Parse(Console.ReadLine());
                    CongNhan congnhanmoi = new CongNhan(hoten, gioitinh, tuoi, diachi, tencongty, ngayvao, hesoluong);
                    dsNguoi.Add(congnhanmoi);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nBan da nhap sai lua chon. Nhan Enter de tiep tuc!");
                    Console.ReadLine();
                    Console.ResetColor();
                    break;
            }
        }
        static private void XuatDanhSachNguoi()
        {
            foreach (Nguoi item in dsNguoi)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

}
