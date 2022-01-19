using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_02
{
    class Bai9
    {
       public static bool isCheck(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            if (isCheck(n))
            {
                Console.WriteLine($"{n} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to");
            }
        }
    }
}
