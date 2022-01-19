using System;

namespace Cau1
{
    public class TinhLuong{
        protected string HoTen{set; get;}
        protected string DiaChi{set; get;}
        protected int HeSoLuong{set; get;}
        protected int LuongCoBan = 1000000;
        protected TinhLuong(){
            HoTen = "";
            DiaChi= "";
            HeSoLuong = 0;
            LuongCoBan = 0;
        }
        public TinhLuong(string HoTen, string DaChi, int HeSoLuong){
            this.HoTen = HoTen;
            this.DiaChi = DiaChi;
            this.HeSoLuong = HeSoLuong;
        }
        // public void Display(){
        //     System.Console.WriteLine("Ho ten la: " + this.HoTen);
        //     System.Console.WriteLine("Dia chi la: " + this.DiaChi);
        //     System.Console.WriteLine("He so luong la: " + this.HeSoLuong);
        // }
        public int TienLuong(){
            int Luong = this.HeSoLuong * this.LuongCoBan;
            return Luong;
        }
    }

    public class NhanVien : TinhLuong{
        private string MaNV{set; get;}
        private  string ChucVu{set; get;}
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Nhap ho ten cua nhan vien: ");
            string HoTen = Console.ReadLine();
            System.Console.Write("\nNhap dia chi cua nhan vien: ");
            string DiaChi = Console.ReadLine();
            System.Console.Write("\nNhap he so luong cua nhan vien: ");
            int HeSoLuong = Int32.Parse(Console.ReadLine());
            TinhLuong nv = new TinhLuong(HoTen, DiaChi, HeSoLuong);
            // nv.Display();
            System.Console.WriteLine("So tien luong cua nhan vien la: " + nv.TienLuong());
        }
    }
}
