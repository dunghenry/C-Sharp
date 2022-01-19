using System;

namespace assignOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = default;
            string str = default;
            int c = b;
            char ch = default;
            object o = default;
            bool bo = default;
            b += a;
            System.Console.WriteLine(c);
            System.Console.WriteLine(str);
            System.Console.WriteLine(ch);
            System.Console.WriteLine(o);
            System.Console.WriteLine(bo);
            System.Console.WriteLine(b);
        }
    }
}
