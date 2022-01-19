using System;

namespace CS.OnTapInterface
{
    interface IHinhHoc{
        public double ChuVi();
        public double DienTich();
    }
    //Có thể kế thừa nhiều interface ví dụ public class HinhChuNhat : GiaoDien1, GiaoDien2, GiaoDien3
    public class HinhChuNhat : IHinhHoc{
        public double ChieuDai{set; get;}
        public double ChieuRong{set; get;}

        public HinhChuNhat(double ChieuDai, double ChieuRong){
            this.ChieuDai = ChieuDai;
            this.ChieuRong = ChieuRong;
        }
        public double ChuVi(){
            return (ChieuDai + ChieuRong) * 2;
        }
        public double DienTich(){
            return ChieuDai * ChieuRong;
        }
    }
    public class HinhVuong : IHinhHoc{
        public double CanhHinhVuong{set; get;}
        public HinhVuong(double canhHinhVuong){
            this.CanhHinhVuong = canhHinhVuong;
        }
        public double ChuVi(){
            return CanhHinhVuong * 4;
        }
        public double DienTich(){
            return Math.Pow(CanhHinhVuong, 2);
        }
    }
    public class HinhTron : IHinhHoc{
        public double r{set; get;}
        public HinhTron(double r){
            this.r = r;
        }
        public double ChuVi(){
            return 2 * Math.PI * r;
        }
        public double DienTich(){
            return Math.PI * r * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Chu vi va Dien tich hinh chu nhat!!!");
            HinhChuNhat hcn = new HinhChuNhat(5, 3);
            Console.WriteLine(hcn.ChuVi());
            Console.WriteLine(hcn.DienTich());
            Console.WriteLine();
            Console.WriteLine("Chu vi va Dien tich hinh vuong!!!");
            IHinhHoc hv = new HinhVuong(5);
            Console.WriteLine(hv.ChuVi());
            Console.WriteLine(hv.DienTich());
            Console.WriteLine();
            Console.WriteLine("Chu vi va Dien tich hinh tron!!!");
            IHinhHoc ht = new HinhTron(2);
            Console.WriteLine(ht.ChuVi());
            Console.WriteLine(ht.DienTich());




        }
    }
}
