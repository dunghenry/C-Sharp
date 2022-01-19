using System;
using static System.Math;
namespace Virtual_method_abstract_interface
{
    class IPhone : Product{
        public IPhone(){
            Price = 500;
        }
        // public IPhone() => Price = 500;

        // override - nạp chồng phương thức
        // public override void ProductInfo()
        // {
        //     System.Console.WriteLine("Dien thoai IPhone");
        //     base.ProductInfo();
        // }

        public void Abc() => System.Console.WriteLine("Hello world");

        public override void ProductInfo(){
            System.Console.WriteLine("Dien thoai Iphone cua toi!!!");
            System.Console.WriteLine($"Gia cua chiec dien thoai Iphone la: {Price}");

            //base.ProductInfo(); //Không gọi đc vì ko pt ko có thân

        }

        int tong(int a, int b) => a + b;
    }

    interface IHinhHoc{
        public double TinhChuvi();
        public double TinhDienTich();
    } 

    interface GiaoDien{
        public int Test();
    }
    class HinhChuNhat : IHinhHoc{
        public double a{ get; set;}
        public double b{ get; set;}
        public HinhChuNhat(double a, double b){
            this.a = a; this.b = b;
        }
        public double TinhChuvi() => (a + b) * 2;
        public double TinhDienTich() => a * b;
    }

    //Đa kế thừa
    class HinhTron : IHinhHoc, GiaoDien{
        public int r{ get; set;}
        public HinhTron(int r){
            this.r = r;
        }
        public double TinhChuvi() => 2 * Math.PI * r;


        public double TinhDienTich() => Math.PI * r * r;

        public int Test() => r;

    }
    class Program
    {

        static void Main(string[] args)
        {
            IPhone i = new IPhone();
            i.Test();

            // Product p = new Product(); //do dung abstract

            //Cách 1
            IHinhHoc a = new HinhChuNhat(3, 5);

            //Cách 2
            // HinhChuNhat a = new HinhChuNhat(2, 5);
            System.Console.WriteLine($"Chu vi hinh chu nhat la {a.TinhChuvi()}");
            System.Console.WriteLine($"Dien tich hinh chu nhat la {a.TinhDienTich()}");
            

            IHinhHoc t = new HinhTron(2);
            GiaoDien b = new HinhTron(3);
            System.Console.WriteLine($"Ban kinh cua hinh tron la: {b.Test()}");
            System.Console.WriteLine($"Chu vi hinh tron la {t.TinhChuvi()}");
            System.Console.WriteLine($"Dien tich hinh tron la {t.TinhDienTich()}");


        }
    }
}
