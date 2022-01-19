using System;

namespace CS.OnTapStruct
{
    // Struct là kiểu tham trị nên cần dùng out để thay đổi gt
    class Program
    {
        struct SinhVien{
            public string HoTen { set; get; }
            public int MaSinhVien{ set; get;}
            public string Lop { set; get; }
            public double DTB{ set; get;}
            public int CMND { set; get;}
            public string DiaChi{ set; get;}    

            //Constructor
            public SinhVien(string HoTen, int MaSinhVien, string Lop, double DTB, int CMND, string DiaChi){
                this.HoTen = HoTen;
                this.MaSinhVien = MaSinhVien;
                this.Lop = Lop;
                this.DTB = DTB;
                this.CMND = CMND;
                this.DiaChi = DiaChi;  
            }
        }
        static void Input(ref SinhVien sv)
        {
            Console.Write("Ho ten: ");
            sv.HoTen = Console.ReadLine();
            Console.Write("Ma sinh vien: ");
            sv.MaSinhVien = int.Parse(Console.ReadLine());
            Console.Write("Lop: ");
            sv.Lop = Console.ReadLine();
            Console.Write("Diem trung binh: ");
            sv.DTB = double.Parse(Console.ReadLine());
            Console.Write("So CMND/CCCD: ");
            sv.CMND = int.Parse(Console.ReadLine());
            Console.Write("Dia chi thuong tru: ");
            sv.DiaChi = Console.ReadLine();
        }
        static void HocLuc(SinhVien sv){
            if(sv.DTB <= 10 && sv.DTB >= 8.5){
                Console.WriteLine("Hoc luc gioi");
            }
            else if(sv.DTB >= 6.5){
                Console.WriteLine("Hoc luc kha");
            }
            else if(sv.DTB >= 5.0){
                Console.WriteLine("Hoc luc trung binh");
            }
            else if(sv.DTB >= 3.5){
                Console.WriteLine("Hoc luc yeu");
            }
            else{
                Console.WriteLine("Hoc luc kem");
            }
        }
        static void Output(SinhVien sv){
            Console.WriteLine("Ho ten: " + sv.HoTen);
            Console.WriteLine("Ma sinh vien: " + sv.MaSinhVien);
            Console.WriteLine("Lop: " + sv.Lop);
            Console.WriteLine("Diem trung binh: " + sv.DTB);
            Console.WriteLine("So CMND/CCCD: " + sv.CMND);
            Console.WriteLine("Dia chi thuong tru: " + sv.DiaChi);
        }
        static void NhapThongTinSV(ref SinhVien[] ListSv){
            for(int i = 0; i < ListSv.Length; i++){
                Console.WriteLine($"Nhap thong tin sinh vien thu: {i + 1}");
                Console.Write("Ho ten: ");
                ListSv[i].HoTen = Console.ReadLine();
                Console.Write("Ma sinh vien: ");
                ListSv[i].MaSinhVien = int.Parse(Console.ReadLine());
                Console.Write("Lop: ");
                ListSv[i].Lop = Console.ReadLine();
                Console.Write("Diem trung binh: ");
                ListSv[i].DTB = double.Parse(Console.ReadLine());
                Console.Write("So CMND/CCCD: ");
                ListSv[i].CMND = int.Parse(Console.ReadLine());
                Console.Write("Dia chi thuong tru: ");
                ListSv[i].DiaChi = Console.ReadLine();
            }
        }
        static void XuatThongTinSV(SinhVien[] ListSv){
            for (int i = 0; i < ListSv.Length; i++){
                Console.WriteLine($"Xuat thong tin sinh vien thu: {i + 1}");
                 Console.WriteLine("Ho ten: " + ListSv[i].HoTen);
                Console.WriteLine("Ma sinh vien: " + ListSv[i].MaSinhVien);
                Console.WriteLine("Lop: " + ListSv[i].Lop);
                Console.WriteLine("Diem trung binh: " + ListSv[i].DTB);
                Console.WriteLine("So CMND/CCCD: " + ListSv[i].CMND);
                Console.WriteLine("Dia chi thuong tru: " + ListSv[i].DiaChi);

            }
        }
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            Console.WriteLine("Nhap thong tin sinh vien:");
            Input(ref sv);
            Console.WriteLine();
            Console.WriteLine("Thong tin sinh vien vua nhap la: ");
            Output(sv);
            HocLuc(sv);

            //!Mảng struct 

            Console.Write("Nhap so sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            SinhVien[] ListSv = new SinhVien[n];
            NhapThongTinSV(ref ListSv);
            XuatThongTinSV(ListSv);
            
        }
    }
}
