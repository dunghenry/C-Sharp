using System;
namespace CS.OnTapVirtual_Override
{
    // abstract public class Person{} //Lớp trừu tượng không dùng để khởi tạo ra các đối tượng chỉ dùng để làm lớp cơ sở
    abstract public class Person{
        public string _HoTen;
        public string HoTen{
            set{
                _HoTen = value;
            }
            get{
                return _HoTen;
            }
        }
        public string _NgaySinh;
        public string NgaySinh{
            set{
                _NgaySinh = value;
            }
            get{
                return _NgaySinh;
            }
        }
        public string _QueQuan;
        public string QueQuan{
            set{
                _QueQuan = value;
            }
            get{
                return _QueQuan;
            }
        }
        //Phưng thức ảo của lớp cơ sở có thể bị ghi đè
        // public virtual void Info(){
        //     Console.WriteLine("This is method virtual Info");
        // }
        public abstract void Info();
        public void Test() => Info();

        public abstract void Display(); //Phương thức trừu tượng lớp kế thừa bắt buộc phải nạp chồng
    }
    public class KYSU : Person{
        public string _Nganh;
        public string Nganh{
            set{
                _Nganh = value;
            }
            get{
                return _Nganh;
            }
        }
        public int _NamTN;
        public int NamTN{
            set{
                _NamTN = value;
            }
            get{
                return _NamTN;
            }
        }
        //Ghi đè nên phương thức ở lớp cơ sở
        // public override void Info(){
        //     Console.WriteLine("This is method override Info");
        //     base.Info(); // Gọi phương thức Info ở lớp cơ sở
        // }
        public override void Info(){
            Console.WriteLine("This is method override Info");
            // base.Info(); //Không gọi đc phương thức của lớp cơ sở vì dùng abstract ko có thân phương thức
        }
        public override void Display(){
            Console.WriteLine("Nạp chồng lại phương thức abstract nhé các bạn!!!");
            // base.Info(); //Gọi đc bt nếu như ko dùng abstract cho phương thức ở lớp cơ sở vì pt abstract không có thân 
        }
        //Constructor
        public KYSU(){

        }
        public KYSU(string HoTen, string NgaySinh, string QueQuan, string Nganh, int NamTN){
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.QueQuan = QueQuan;
            this.Nganh = Nganh;
            this.NamTN = NamTN;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KYSU ks = new KYSU();
            ks.Display();
            
        }
    }
}
