using System;

namespace BTH_HAUI_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
}
