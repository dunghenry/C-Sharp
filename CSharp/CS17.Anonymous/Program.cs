using System;
using System.Collections.Generic;
using System.Linq;
namespace Anonymous
{
    class Program
    {
         class SinhVien{
                public string HoTen { get; set; }
                public int NamSinh { get; set; }
                public string NoiSinh { get; set; }
            }

        static void Main(string[] args)
        {
            //Anonymous chỉ đọc
            var sanpham = new{
                TenSP = "Iphone 13",
                Gia = 30000000,
                NamSX = 2021
            };
            System.Console.WriteLine(sanpham.TenSP);
            System.Console.WriteLine(sanpham.Gia);
            System.Console.WriteLine(sanpham.NamSX);

            //

            List<SinhVien> cacsinhvien = new List<SinhVien>(){
                new SinhVien(){HoTen = "Tran Van A", NamSinh = 2001, NoiSinh = "Ninh Binh"},
                new SinhVien(){HoTen = "Tran Van B", NamSinh = 2002, NoiSinh = "Nam Dinh"},
                new SinhVien(){HoTen = "Tran Van C", NamSinh = 2003, NoiSinh = "Ha Noi"},
                new SinhVien(){HoTen = "Tran Van D", NamSinh = 2004, NoiSinh = "TPHCH"}
            };
            var ketqua = from sv in cacsinhvien
                        // where sv.NamSinh < 2003
                        // where sv.HoTen ==  "Tran Van D"
                        where sv.HoTen.Contains("A")
                        select new{
                            HoTen = sv.HoTen,
                            NamSinh = sv.NamSinh,
                            NoiSinh = sv.NoiSinh,
                        };
            foreach (var sinhvien in ketqua){
                Console.WriteLine($"{sinhvien.HoTen} { sinhvien.NamSinh}");
            }


            //dynamic có thể gán bất kì cho kiểu dl gì, thực thi ms báo lỗi 

            dynamic bien;
            bien  = 10;

        }
    }
}
