using System;
namespace Controls
{
    public class Bai3
    {
        static void Main(){
            System.Console.Write("Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            int h = a - b;
            int n = a * b;
            float c = (float) a / b;
            int du = a % b;
            System.Console.WriteLine($"({a} + {b}) = {sum}");
            System.Console.WriteLine($"({a} +-{b}) = {h}");
            System.Console.WriteLine($"({a} * {b}) = {n}");
            System.Console.WriteLine($"({a} / {b}) = {c}");
            System.Console.WriteLine($"({a} % {b}) = {du}");
        }
    }
}