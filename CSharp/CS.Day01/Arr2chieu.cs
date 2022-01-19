using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp
{
    class Arr2chieu
    {
        static void Main()
        {
            double[,] numbers = new double[2, 3] { {2, 3, 4 }, {3, 4, 5 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(numbers[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
