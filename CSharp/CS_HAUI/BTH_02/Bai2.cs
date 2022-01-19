using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_02
{
    class Bai2
    {
        static void Main()
        {
            Console.Write("Nhap n tu ban phim: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            Console.Write("Sum la: " + sum);
        }
    }
}
