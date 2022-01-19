using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_02
{
    class Bai7
    {
        static void Main()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine($"{i} la uoc cua {n}");
                    dem++;
                }
            }
            Console.WriteLine($"{n} co so uoc la: {dem}");
        }
    }
}
