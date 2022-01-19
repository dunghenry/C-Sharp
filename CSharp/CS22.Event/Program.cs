using System;
namespace Event
{
    public delegate void SuKienNhapSo(int x);
    class Dulieunhap : EventArgs{
        public int data{set; get;}
        public Dulieunhap(int x) => data = x;
    }
    class UserInput{
        // public event SuKienNhapSo su_kien_nhap_so;
        public event EventHandler su_kien_nhap_so;
        public void Input(){
            do
            {
                System.Console.Write("Nhap vao mot so nguyen bat ki: ");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                // su_kien_nhap_so?.Invoke(i);

                su_kien_nhap_so?.Invoke(this, new Dulieunhap(i));
            } while (true);
        }
    }
    
    class TinhCan{
        public void Sub(UserInput input){
            input.su_kien_nhap_so += Can;
        }

        public void Can(object sender, EventArgs e){
            Dulieunhap dulieunhap = (Dulieunhap)e;
            int i = dulieunhap.data;
             Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"\nCan ba hai cua {i} la {Math.Sqrt(i)}");
            Console.ResetColor();
        }
        // public void Can(int i){
        //     Console.ForegroundColor = ConsoleColor.Red;
        //     System.Console.WriteLine($"\nCan ba hai cua {i} la {Math.Sqrt(i)}");
        //     Console.ResetColor();
        // }
    }
    class BinhPhuong{
        public void Sub(UserInput input){
            input.su_kien_nhap_so += TinhBinhPhuong;
        }

        public void TinhBinhPhuong(object sender, EventArgs e){
            Dulieunhap dulieunhap = (Dulieunhap)e;
            int i = dulieunhap.data;
             Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Binh phuong cua {i} la {i * i}");
            Console.ResetColor();
        }
        // public void TinhBinhPhuong(int i){
        //     Console.ForegroundColor = ConsoleColor.Red;
        //     System.Console.WriteLine($"Binh phuong cua {i} la {i * i}");
        //     Console.ResetColor();
        // }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.CancelKeyPress += (sender, e) =>{
                System.Console.WriteLine();
                System.Console.WriteLine("Thoat ung dung!!!");
            };
            //publisher
            UserInput userInput = new UserInput();
            userInput.su_kien_nhap_so += (sender, e) =>{
                Dulieunhap dulieunhap = (Dulieunhap)e;
                System.Console.Write("Ban vua nhap so : " + dulieunhap.data);
            };

            //subcriber
            TinhCan tinhCan = new TinhCan();
            tinhCan.Sub(userInput);
            BinhPhuong tinhBP = new BinhPhuong();
            tinhBP.Sub(userInput);
            userInput.Input();
        }
    }
}
