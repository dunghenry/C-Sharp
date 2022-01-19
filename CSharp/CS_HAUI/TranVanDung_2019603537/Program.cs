using System;
using System.Collections.Generic;
namespace TranVanDung_2019603537_proj51
{
    class Program
    {
        static private List<ThisinhA> dsThiSinh = new List<ThisinhA>();
        static void Main(string[] args)
        {
            do
            {
                //Tạo menu
                Console.Clear();
                Console.WriteLine("\nMAIN MENU:");
                Console.WriteLine("\n1. Nhap thong tin 1 thi sinh.");
                Console.WriteLine("\n2. Hien thi danh sach cac thi sinh.");
                Console.WriteLine("\n3. Hien thi cac sinh vien theo tong diem.");
                Console.WriteLine("\n4. Hien thi cac sinh vien theo dia chi.");
                Console.WriteLine("\n5. Tim kiem theo so bao danh.");
                Console.WriteLine("\n6. Ket thuc chuong trinh.");
                Console.Write("\nNhap vao lua chon cua ban:");
                string luaChon = Console.ReadLine();
                switch (luaChon)//kiểm tra các lựa chọn của user
                {
                    case "1":
                        NhapThongTinThiSInh();
                        Console.ReadLine();
                        break;
                    case "2":
                        HienThiDsThiSinh();
                        Console.ReadLine();
                        break;
                    case "3":
                        HienThiTheoTongDiem();
                        Console.ReadLine();
                        break;
                    case "4":
                        HienThiTheoDiaChi();
                        Console.ReadLine();
                        break;
                    case "5":
                        Timkiem();
                        Console.ReadLine();
                        break;
                    case "6":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nBan da nhap sai lua chon. Nhan Enter de tiep tuc!");
                        Console.ReadLine();
                        Console.ResetColor();
                        break;
                }
            } while (true);
        }
        static private void NhapThongTinThiSInh()
        {
            int sbd;
            string hoten, diachi;
            double dt, dl, dh, duutien;

            Console.Write("Nhap so bao danh: ");
            sbd = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diachi = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            dt = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly: ");
            dl = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            dh = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem uu tien: ");
            duutien = double.Parse(Console.ReadLine());

            ThisinhA newTS = new ThisinhA(sbd, hoten, diachi, dt, dl, dh, duutien);
            dsThiSinh.Add(newTS);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Them thanh cong!\nEnter de tiep tuc!");
            Console.ResetColor();
        }
        static private void HienThiDsThiSinh()
        {
            Console.Clear();
            Console.WriteLine("\n{0,-15}{1,-20}{2,-15}{3,-18}{4,-15}{5,-15}{6,-18}{7,-15}", "So bao danh", "Ho ten", "Dia Chi", "Diem toan", "Diem ly", "Diem hoa", "Diem uu tien", "Tong diem");
            foreach (ThisinhA i in dsThiSinh)
                Console.WriteLine(i.ToString());
            Console.WriteLine("\nEnter de tiep tuc!");
        }
        static private void HienThiTheoTongDiem()
        {
            Console.Write("Nhap vao mot tong diem: ");
            double td = double.Parse(Console.ReadLine());

            foreach (ThisinhA item in dsThiSinh)
                if (item.TongDiem() >= td)
                    HienThiDsThiSinh();
                else
                    Console.WriteLine("Khong co thi sinh nao");
        }
        static private void HienThiTheoDiaChi()
        {
            Console.Write("Nhap mot dia chi: ");
            string dc = Console.ReadLine();
            foreach (ThisinhA item in dsThiSinh)
                if (item.DiaChi == dc)
                    HienThiDsThiSinh();
                else
                    Console.WriteLine("Khong co thi sinh nao");
        }
        static private void Timkiem()
        {
            Console.Write("Nhap so bao danh can tim kiem: ");
            int SBD = int.Parse(Console.ReadLine());
            foreach (ThisinhA item in dsThiSinh)
            {
                if (item.SoBaoDanh == SBD)
                    Console.WriteLine(item.ToString());
            }
        }
    }
}
