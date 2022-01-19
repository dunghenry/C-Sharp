using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLoopControls
{
    class WhileLoop
    {
        static void Main()
        {
            Console.WriteLine("Nhap so n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int sum = 0;
            while(i < n)
            {
                sum += i;
               if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
