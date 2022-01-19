using System;
using System.Text;
namespace dataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            // Các kiểu dữ liệu hay sd float int double 
            int a = 10;
            string fullName = "Trần Văn Dũng";
            string myEmail = "trandungksnb00@gmail.com";
            int b = 20, c = 5;
            int sum = a + b + c;
            float div =  (float) b / a;
            Console.WriteLine("a = " + a);
            Console.WriteLine("Full name: = " + fullName);
            Console.WriteLine("a + b + c = " + sum);
            Console.WriteLine("b / a = " + div);
            System.Console.WriteLine("myEmail = " + myEmail);
            }
    }
}
