using System;

namespace logicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b = 201;

            bool isOk = (a % 2 == 0) || (b % 2 == 0);
            System.Console.WriteLine(isOk);

            bool isOkTwo = (a % 2 == 0) && (b % 2 == 0);
            System.Console.WriteLine(isOkTwo);

            bool isOkThree = !isOkTwo;
            System.Console.WriteLine(isOkThree);
        }
    }
}
