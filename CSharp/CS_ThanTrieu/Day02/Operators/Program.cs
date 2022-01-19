using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 101.10f;
            int b = 20;
            float sum =  a + b;
            float H = (int) a - b;
            float N = (int) a * b;
            float div = (int) a / b;
            float du = (int) a % b;
            int c = b++ - ++b;
            // 5 - 7
            string str = "Hello";

            Console.WriteLine(sum);
            Console.WriteLine(H);
            Console.WriteLine(N);
            Console.WriteLine(div);
            Console.WriteLine(du);
            Console.WriteLine(c);
            Console.WriteLine(str+a+a);
            //!Nhận chuỗi
            Console.WriteLine(str + (a + a));
            // ?Nhận chuỗi + nunber
        }
    }
}
