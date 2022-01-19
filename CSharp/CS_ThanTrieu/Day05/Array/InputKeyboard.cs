using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class InputKeyboard
    {
        static void Main()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[n];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                names[i] = Console.ReadLine();
            }
            Console.Write("Xuat mang:\t");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i]+"\t");
            }
        }
    }
}
