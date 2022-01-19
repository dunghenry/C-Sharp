using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_02
{
    class Bai4
    {
        static void TBC(int n)
        {
            int dem = 0;
            double sum = 0;
            for (int i = 0; i <= n; i++)  
            {
                sum += i;
                dem++;
            }
            Console.Write("TBC la: " + (double) sum / dem);
        }
        static void TBCodd(int n)
        {
            int dem = 0;
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if(i % 2 != 0)
                {
                    sum += i;
                    dem++;
                }
            }
            Console.Write("\nTBC Odd la: " + (double) sum / dem);
        }
        static void TBCEvent(int n)
        {
            int dem = 0;
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    dem++;
                }
            }
            Console.Write("\nTBC Even la: " + (double)sum / dem);
        }
        static void Main()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            TBC(n);
            TBCodd(n);
            TBCEvent(n);
        }
    }
}
