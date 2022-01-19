using System;
using System.Text;
namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double a, b, c, P, S;
            Console.Write("Nhap canh a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            c = Convert.ToDouble(Console.ReadLine());
            if((a + b) > c && (b + c) > a && (c + a) > b && a > 0 && b > 0 && c > 0){
                P = a + b + c;
                double PHalf = P / 2;
                S = Math.Sqrt(PHalf *(PHalf - a)*(PHalf - b)*(PHalf - c));
                Console.WriteLine("P = " + P);
                Console.WriteLine("S = " + S);
            }
            else{
                Console.WriteLine("Không phải là tam giác");
            }
            
            Console.ReadKey();
        }
    }
}
