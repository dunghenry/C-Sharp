using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Vukhi Sungluc = new Vukhi();
            Console.WriteLine(Sungluc.name);
            Sungluc.DoSatThuong(5);
            Sungluc.TanCong();

            //Set và lấy value = 5
            //Sungluc.SatThuong = 5;

            //Truy cập nên trả về gt 
            Console.WriteLine(Sungluc.SatThuong);

            Sungluc.Noisanxuat = "My";
            Console.WriteLine(Sungluc.Noisanxuat);
            //Vukhi Sungmay = new Vukhi("Sung may", 10);
            //Sungmay.TanCong();

        }
    }
}
