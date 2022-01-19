using System;
using System.Collections.Generic;
namespace CS.OnTapOOP
{
    public class SinhVien{
            public string _HoTen;
            public string HoTen{ 
                set{
                    _HoTen = value;
                }
                get{
                    return _HoTen;
                }
            }
            public int _MaSinhVien;
            public int MaSinhVien{ 
                set{
                    _MaSinhVien = value;
                } 
                get{
                    return _MaSinhVien;
                } 
            }
            public string _Lop;
            public string Lop { 
                set{
                    _Lop = value;
                }
                get{
                    return _Lop;
                }
            }
            public double _DTB;
            public double DTB{
                set{
                    _DTB = value;
                }
                get{
                    return _DTB;
                }
            }
            public int _CMND;
            public int CMND { 
                set{
                    _CMND = value;
                }
                get{
                    return _CMND;
                }
            }
            public string  _DiaChi;
            public string DiaChi{
                set{
                    _DiaChi = value;
                }
                get{
                    return  _DiaChi;
                }
            }   

            //Constructor
            public SinhVien(){

            }
            public SinhVien(string HoTen, int MaSinhVien, string Lop, double DTB, int CMND, string DiaChi){
                this.HoTen = HoTen;
                this.MaSinhVien = MaSinhVien;
                this.Lop = Lop;
                this.DTB = DTB;
                this.CMND = CMND;
                this.DiaChi = DiaChi;  
            } 
            public void Input()
            {
                Console.Write("Ho ten: ");
                HoTen = Console.ReadLine();
                Console.Write("Ma sinh vien: ");
                MaSinhVien = int.Parse(Console.ReadLine());
                Console.Write("Lop: ");
                Lop = Console.ReadLine();
                Console.Write("Diem trung binh: ");
                DTB = double.Parse(Console.ReadLine());
                Console.Write("So CMND/CCCD: ");
                CMND = int.Parse(Console.ReadLine());
                Console.Write("Dia chi thuong tru: ");
                DiaChi = Console.ReadLine();
            }
            public void Output()
            {
                Console.WriteLine("Ho ten: " + HoTen);
                Console.WriteLine("Ma sinh vien: " + MaSinhVien);
                Console.WriteLine("Lop: " + Lop);
                Console.WriteLine("Diem trung binh: " + DTB);
                Console.WriteLine("So CMND/CCCD: " + CMND);
                Console.WriteLine("Dia chi thuong tru: " + DiaChi);
            }
            public virtual double DiemTrungBinh(){
                return this.DTB;
            }
            public double DiemTrungBinh(double DTB){
                return DTB;
            }
            //Phương thức ghi đè
            public override string ToString()
            {
                return string.Format("\n{0,-15}{1,-20}{2,-15}{3,-18}{4,-15}{5,-15}", this.HoTen, this.MaSinhVien, this.Lop, this.DTB, this.CMND, this.DiaChi);
            }
        }
    class Program
    {
        static private List<SinhVien> ListSV = new List<SinhVien>();
        static private void NhapThongTinSV(){
            string HoTen, DiaChi, Lop;
            int MaSinhVien, CMND;
            double DTB;
            Console.Write("Ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Ma sinh vien: ");
            MaSinhVien = int.Parse(Console.ReadLine());
            Console.Write("Lop: ");
            Lop = Console.ReadLine();
            Console.Write("Diem trung binh: ");
            DTB = double.Parse(Console.ReadLine());
            Console.Write("So CMND/CCCD: ");
            CMND = int.Parse(Console.ReadLine());
            Console.Write("Dia chi thuong tru: ");
            DiaChi = Console.ReadLine();
            SinhVien DSSV = new SinhVien(HoTen, MaSinhVien, Lop, DTB, CMND, DiaChi);
            ListSV.Add(DSSV);
        }
        static private void XuatThongTinSV(){
            Console.WriteLine("\n{0,-15}{1,-20}{2,-15}{3,-18}{4,-15}{5,-15}", "HoTen", "MaSinhVien", "Lop", "DTB", "CMND", "DiaChi");
            foreach(SinhVien i in ListSV){
                Console.WriteLine(i.ToString());
            }      
        }   
        static private void HienThiDiemTrungBinh(){
            double dtb = 5;
            foreach (SinhVien item in ListSV)
            {
                if(item.DiemTrungBinh() >= dtb){
                    XuatThongTinSV();
                }
                else{
                    Console.WriteLine($"Khong co sinh vien nao co dtb > {dtb}");
                }
            }
        }
        static void Main(string[] args)
        {
            // SinhVien sv = new SinhVien();
            // Console.WriteLine("Nhap thong tin sinh vien: ");
            // sv.Input();
            // Console.WriteLine("Xuat thong tin sin vien: ");
            // sv.Output();

            do
            {
                Console.Clear();
                Console.WriteLine("\nMENU:");
                Console.WriteLine("\n1. Nhap thong tin 1 thi sinh.");
                Console.WriteLine("\n2. Hien thi danh sach cac thi sinh.");
                Console.WriteLine("\n3. Hien thi danh sach cac thi sinh theo dtb.");
                Console.Write("\nNhap vao lua chon cua ban:");
                string luaChon = Console.ReadLine();
                switch (luaChon)
                {
                    case "1":
                    {
                        NhapThongTinSV();
                        Console.ReadLine();
                        break;
                    }
                    case "2":
                    {
                        XuatThongTinSV();
                        Console.ReadLine();
                        break;
                    }
                    case "3":
                    {
                        HienThiDiemTrungBinh();
                        Console.ReadLine();
                        break;
                    }
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nBan da nhap sai lua chon. Nhan Enter de tiep tuc!");
                        Console.ReadLine();
                        Console.ResetColor();
                        break;
                }
            } while(true);
        }
    }
}
