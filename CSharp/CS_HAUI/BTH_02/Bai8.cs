using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_02
{
    class Bai8
    {
        static void Main()
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            int min;
            if(a > b)
            {
                min = b;
            }
            else
            {
                min = b;
            }
            for (int i = min; i > 0 ; i--)
            {
                if(a % i == 0 && b % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            int maxV = a * b;
            int max;
            if(a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            for (int i = max; i <= maxV ; i+= max)
            {
                if(i % a == 0 && i % b == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
