using System;
using System.Collections.Generic;
namespace CS.OnTapDelegates
{
    class Program
    {
        public delegate void Display(string message);
        static void Info(string str){
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(str);
            Console.ResetColor();
        }
        static void Warning(string str){
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(str);
            Console.ResetColor();
        }
        static int Tong(int a, int b) => a + b;
        static void Sum(int a, int b, Display display){
            int kq = a + b;
            display?.Invoke($"Tong la: {kq}");
        }
        static void Main(string[] args)
        {
           Display display;

           display = Info;
           display += Warning;

           display("Hi"); //Kaka(color green)
           display?.Invoke("Hello"); // Hello(color red)

            Action<string> action; // = delegate void MethodName(string str);

            action = Info;
            action?.Invoke("Kaka"); // Kaka(color green)

            Func<int, int, int> func; // delegate int MethodName(int num1, int num2)
            func = Tong;
            Console.WriteLine(func(1, 2)); // 3

            Sum(5, 10, Warning);
        }
    }
}
