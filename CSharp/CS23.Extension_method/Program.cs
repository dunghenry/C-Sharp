using System;
using System.Linq;
using MyLib;
namespace Extension_method
{
    static class Abc{
        public static void Print(this string s, ConsoleColor color){
            Console.ForegroundColor = color;
            Console.WriteLine(s);
        }
    }
    class Program
    {
        // public static void Print(string s, ConsoleColor color){
        //     Console.ForegroundColor = color;
        //     Console.WriteLine(s);
        // }

        static void Main(string[] args)
        {
            int[] a = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            int max = a.Max();
            Console.WriteLine(max);

            string s = "Xin chao cac ban!!";

            // Print(s, ConsoleColor.Yellow);
            s.Print(ConsoleColor.Red);
                
            double x = 2.5;
           Console.WriteLine(x.CanBacHai());

            
        }
    }
}
