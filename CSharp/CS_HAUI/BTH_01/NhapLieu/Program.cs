using System;

namespace NhapLieu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap n bat ki tu 1 den 100: ");
            int n = int.Parse(Console.ReadLine());
            //a,
            while (n < 1 || n > 100)
            {
                Console.Write("Nhap lai n bat ki tu 1 den 100: ");
                n = int.Parse(Console.ReadLine());
            }
            //b,
            do
            {
                Console.Write("Nhap n bat ki tu 1 den 100: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 || n > 100);

        }
    }
}
