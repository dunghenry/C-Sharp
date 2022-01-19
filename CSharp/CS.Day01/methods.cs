using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp
{
    class methods
    {
        public static void XinChao(string ho, string ten)
        {
            string fullName;
            fullName = ho + " " + ten;
            Console.WriteLine($"Xin chao {fullName}");
        }
        public static int Tich(int a, int b)
        {
            return a * b;
        }
        static void Main()
        {
            XinChao(ho: "Tran", ten: "Dung");
            Console.WriteLine();
            int tich = Tich(4, 5);
            Console.WriteLine(tich);
            int sum = Learn_CSharp.tinhTong.sum(10, 20);
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
