using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH_02
{
    class Bai11
    {
        static void Main()
        {
            Console.Write("Nhap n > 0: ");
            int n = int.Parse(Console.ReadLine());
            while(n <= 0)
            {
                Console.Write("Nhap lai n > 0: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(n);
        }
    }
}
