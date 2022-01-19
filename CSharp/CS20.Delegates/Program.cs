using System;
using System.Collections.Generic;
namespace Using_delegates
{
    public delegate void ShowLog(string message);
    class Program
    {
        static void Info(string s){
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Warning(string s){
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(s);
            Console.ResetColor();
        }

        static int Tong(int a, int b) => a + b;
        static int Hieu(int a, int b) => a - b;

        static void Sum(int a, int b, ShowLog log){
            int kq = a + b;
            log?.Invoke($"Tong la: {kq}");
        }

        // delegate int Kieu();

        static void Main(string[] args)
        {
            //Delegate

            ShowLog log = null;
            log = Info;
            // log += Warning;
            // log += Warning;
            log += Info;
            if(log != null)
                log("Xin chao");
            // log?.Invoke("Hi");
            // log.Invoke("Hi");

            // //! Delegate action no return
            Action action; //~ delegate void Kieu();
            Action<string, int> action1; //~ delegate void Kieu(string s, int i);
            Action<string> action2; //~ delegate void Kieu(string s);

            action2 = Warning;
            action2 += Info;
            action2?.Invoke("Hello cac ban");

            // ? Delegate function return

            Func<int> f1;  //~ delegate int Kieu();
            Func<string, int, string> f2;  //~ delegate string Kieu(string s, int i);

            Func<int, int, int> f3;
            Func<int, int, int> f4;
            f3 = Tong;
            f4 = Hieu;
            int a = 10;
            int b = 5;
            System.Console.WriteLine($"Tong la: {f3(a, b)}");
            System.Console.WriteLine($"Hieu la: {f4(a, b)}");

            Sum(2, 4, Info);

        }
    }
}
