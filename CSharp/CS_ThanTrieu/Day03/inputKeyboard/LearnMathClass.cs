// using System.Text.RegularExpressions;
using System;
namespace inputKeyboard
{
    public class LearnMathClass
    {
        static void Main(){
            int max = Math.Max(10, 20);
            int min = Math.Min(10, 20);
            double x = -100.2;
            double y = Math.Abs(x);
            double a = Math.Sqrt(120);
            System.Console.WriteLine($"Max({10}, {20}) = {max}");
            System.Console.WriteLine($"Min({10}, {20}) = {min}");
            System.Console.WriteLine($"|{x}| = {y}");
            System.Console.WriteLine(a);
            System.Console.WriteLine("PI = " + Math.PI);
        }
    }
}