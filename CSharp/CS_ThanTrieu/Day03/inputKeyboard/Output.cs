using System;
using System.Text;
namespace inputKeyboard
{
    public class Output
    {
        static void Main(){
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập số a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số a: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("a + b = " + sum);
            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
            Console.WriteLine($"{a} + {b} = {sum}");
        }
    }
}