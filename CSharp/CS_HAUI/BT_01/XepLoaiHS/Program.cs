using System;
using System.Text;
namespace XepLoaiHS
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            double points;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập tên học sinh: ");
            fullName = Console.ReadLine();
            Console.Write("Nhập điểm học sinh: ");
            points = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(fullName.ToUpper());
            if(points >= 8){
                Console.WriteLine("Xếp loại kết quả Giỏi");
            }
            else if(points >= 6.5){
                Console.WriteLine("Xếp loại kết quả Khá");
            }
            else if(points >= 5){
                Console.WriteLine("Xếp loại kết quả Trung bình");
            }
            else{
                Console.WriteLine("Xếp loại kết quả Yếu"); 
            }

        }
    }
}
