using System;
using System.Text;
namespace inputKeyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập họ và tên của bạn: ");
            string fullName = Console.ReadLine();
            Console.Write("Nhập tuổi của bạn: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tuổi của bạn: ");
            int ageTwo = System.Int32.Parse(Console.ReadLine());
            Console.Write("Nhập điểm của bạn: ");
            float avgMark = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhập điểm của bạn: ");
            float avgMarkTwo = System.Single.Parse(Console.ReadLine());
            Console.WriteLine("Hello " + fullName);
            Console.WriteLine("I' am " + age);
            Console.WriteLine("I' am " + ageTwo);
            Console.WriteLine("My avg mark is " + avgMark);
            Console.WriteLine("My avg mark is " + avgMarkTwo);
            
        }
    }
}
