using System;
using x = System.Console;
using static System.Console;
using static System.Math;
using xyz = MyNamespace.Abc;
using MyNamespace;
using Sanpham;
namespace Namespace_Partial
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1.XinChao();

            xyz.Class1.XinChao();

            System.Console.WriteLine(PI);

            x.WriteLine("Hello");

            WriteLine("Hello");

            Product sp = new Product();
            sp.name = "Realme C2";
            sp.price = 2000000;
            sp.Description = "Dien thoai cua toi!!";
            Console.WriteLine(sp.GetInfo());

            sp.manufactore = new Product.Manufactore();
            sp.manufactore.name = "Oppo";
            sp.manufactore.address  = "China";
            // Console.WriteLine(sp.manufactore.name);
        }
    }
}
