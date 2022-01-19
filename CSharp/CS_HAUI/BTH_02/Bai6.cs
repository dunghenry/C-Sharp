using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_02
{
    class Bai6
    {
        static void Main()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap k: ");
            int k = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if(i % k == 0)
                {
                    sum += i;
                }
            }
            Console.Write("Sum la: "+ sum);
        }
    }
}
