using System;
using System.Text;
namespace TongChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int n, S1 = 0;
            double S2 = 0;
            Console.Write("Nhập số nguyên dương n:");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++){
                S1 += i;
                S2 += (double) 1 / i;
            }
            Console.WriteLine(S1);
            Console.WriteLine(S2);
        }
    }
}
