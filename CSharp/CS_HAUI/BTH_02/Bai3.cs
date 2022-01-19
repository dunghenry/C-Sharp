using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_02
{
    class Bai3
    {
        static void Main()
        {
            Console.Write("Nhap n tu ban phim: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }
            Console.Write("Sum la: " + sum);
        }
    }
}
