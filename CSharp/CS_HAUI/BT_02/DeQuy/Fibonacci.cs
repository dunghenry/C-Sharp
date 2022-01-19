using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeQuy
{
    class Fibonacci
    {
        public static int fibonacci(int n)
        {
            if(n < 0)
            {
                return -1;
            }
            else if(n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2); 
            }
        }
        static void Main()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while(i < n)
            {
                Console.WriteLine(fibonacci(i));
                i++;
            }
        }
    }
}
