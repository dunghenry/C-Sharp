using System;

namespace CanBacHai
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, xn, ketqua;
            Console.Write("Nhap a: ");
            a = Convert.ToDouble(Console.ReadLine());
            xn = (a + 1) / 2;
            do
            {
                ketqua = xn;
                xn =  0.5 * ((xn - 1) + a / (xn - 1));
            } while ((xn - ketqua) > 0.00001);
    
            Console.WriteLine("Can bac 2 cua a = " + xn);
        }
    }
}
