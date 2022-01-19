using System;

namespace compareOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b = 201;
            bool check = a > b;
            System.Console.WriteLine(check);
            bool checkTwo = !check;
            System.Console.WriteLine(checkTwo);
            System.Console.WriteLine(a!=b);
        }
    }
}
