using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp
{
    class TestArrr
    {
        static void Main()
        {
            int[] a = { 1, 4, 2, 3, 4 };
            Array.Sort(a);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
