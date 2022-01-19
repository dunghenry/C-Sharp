using System;

namespace CS.OnTapEvent
{
    class Dulieunhap : EventArgs{
        public int data{set; get;}
        public Dulieunhap(int x) => data = x;
    }
    public delegate void SuKienNhappSo(int x);
    class UserInput{
        // public SuKienNhappSo su_kien_nhap_so{set; get;}
        // public event SuKienNhappSo su_kien_nhap_so;

        public event EventHandler su_kien_nhap_so;
        public void Input(){
           do
            {
                Console.Write("Nhap vao mot so bat ki: ");
                string str = Console.ReadLine();
                int i = Int32.Parse(str);
                // su_kien_nhap_so?.Invoke(i);  
                su_kien_nhap_so?.Invoke(this, new Dulieunhap(i));  

            } while (true);
        }

    }
    class TinhCan{
        public void Sub(UserInput input){
            // input.su_kien_nhap_so = Can;
            input.su_kien_nhap_so += Can;
        }
        // public void Can(int x){
        //     Console.WriteLine($"Can bac hai cua so {x} la : {Math.Sqrt(x)}");
        // }
        public void Can(object sender, EventArgs args){
            Dulieunhap dulieunhap = (Dulieunhap)args;
            int x = dulieunhap.data;
            Console.WriteLine($"Can bac hai cua so {x} la : {Math.Sqrt(x)}");
        }
    }

    class BinhPhuong{
        public void Sub(UserInput input){
            // input.su_kien_nhap_so = BinhP;
            input.su_kien_nhap_so += BinhP;
        }
        // public void BinhP(int x){
        //     Console.WriteLine($"Binh phuong cua {x} la : {x * x}");
        // }
        public void BinhP(object sender, EventArgs args){
            Dulieunhap dulieunhap = (Dulieunhap)args;
            int x = dulieunhap.data;
            Console.WriteLine($"Binh phuong cua {x} la : {x * x}");
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.CancelKeyPress += (sender, e)=>{
                Console.WriteLine();
                Console.WriteLine("Thoat ung dung haha");
            };
            UserInput input = new UserInput();
            input.su_kien_nhap_so += (sender, e) =>{
                Dulieunhap dulieunhap = (Dulieunhap)e;
                
                Console.WriteLine("Ban vua nhap so: " + dulieunhap.data);
            };
            TinhCan tinhcan = new TinhCan();
            tinhcan.Sub(input);
            BinhPhuong binhPhuong = new BinhPhuong();
            binhPhuong.Sub(input);
            input.Input();
        }
    }
}
