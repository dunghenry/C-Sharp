using System;

namespace Learn_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n tu ban phim: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        Console.WriteLine("Thang ban vua nhap co 31 ngay");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Thang ban vua nhap co 28 hoac 29 ngay");
                        break;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        Console.WriteLine("Thang ban vua nhap có 30 ngay");
                        break;
                    }

                default:
                    Console.WriteLine("Lua chon khong hop le");
                    break;
            }
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("1, Tinh tong hai so a va b!!!!");
            Console.WriteLine("2, Tinh hieu hai so a va b!!!!");
            Console.WriteLine("3, Tinh tich hai so a va b!!!!");
            Console.WriteLine("4, Tinh thuong hai so a va b!!!!");
            char c;
            L1:
            Console.Write("Nhap lua chon cua ban: ");
            c = Console.ReadKey().KeyChar;
            switch (c)
            {
                case '1':
                    {
                        Console.WriteLine($"\n{a} + {b} = {a + b}");
                        break;
                    }
                case '2':
                    {
                        Console.WriteLine($"\n{a} - {b} = {a - b}");
                        break;
                    }
                case '3':
                    {
                        Console.WriteLine($"{a} x {b} = {a * b}");
                        break;
                    }
                case '4':
                    {
                        Console.WriteLine($"\n{a} / {b} = {a / b}");
                        break;
                    }
                default:
                    Console.WriteLine("\nLua chon khong hop le!!");
                        goto L1;
                    break;
            }

        }
    }
    
}
