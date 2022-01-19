using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp
{
    class Loop
    {
        static void Main()
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            int j = 0;
            while(j <= n)
            {
                Console.Write(j + "\t");
                j++;
            }
            Console.WriteLine();
            int k = 0;
            do
            {
                Console.Write(k + "\t");
                k++;
                if (k == 3)
                    break;
            } while (k <= n);
            Console.WriteLine();
            for (int l = 0; l <= n; l++)
            {
                if (l % 2 == 0)
               
                    continue;
                    Console.Write(l + "\t");
               
            }

        }
    }
}
