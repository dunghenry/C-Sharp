using System;
using System.Linq;
using MyLib;
namespace CS.OnTapExtension_method
{
    static class A{
        public static void Print(this string str, ConsoleColor color){
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8};
            int max = numbers.Max();
            Console.WriteLine("Phần tử lớn nhất của mảng là: " + max);

            string str = "Hello các bạn";
            str.Print(ConsoleColor.Red);

            double a = 2.5;
            double b = a.BinhPhuong();
            double c = a.CanBacHai();
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
