using System;

namespace HinhChuNHat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu dai: ");
            double r = double.Parse(Console.ReadLine());
            double cv, dt;
            cv = (d + r) * 2;
            dt = d * r;
            Console.WriteLine("Chu vi la: " + cv);
            Console.WriteLine("Chu vi la: " + dt);
        }
    }
}
