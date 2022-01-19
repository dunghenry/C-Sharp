using System;

namespace GiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int gt = 1;
                if(n == 0)
                {
                    gt = n;
                }
                for (int i = 1; i <= n; i++)
                {
                    gt *= i;
                }
               
         
            Console.WriteLine(gt);
        }
    }
}
