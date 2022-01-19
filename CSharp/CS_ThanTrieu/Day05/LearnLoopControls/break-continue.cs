using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLoopControls
{
    class break_continue
    {
        static void Main()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                    continue;
                Console.WriteLine(i);

            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            { 
                Console.WriteLine(i);
                if (i == 5)
                    break;
            }
        }
    }
}
