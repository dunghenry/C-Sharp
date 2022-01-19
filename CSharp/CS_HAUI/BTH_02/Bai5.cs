using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_02
{
    class Bai5
    {
        static void Main()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int gt = 1;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                gt *= i;
                sum += gt;

            }
            Console.Write("Gt la: " + sum);
        }
    }
}
