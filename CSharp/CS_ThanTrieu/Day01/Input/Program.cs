using System;
using System.Text;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Nhập tên đầy đủ của bạn: ");

            string fullName = Console.ReadLine();

            Console.Write("Nhập tuổi của bạn: ");

            int age = Convert.ToInt32(Console.ReadLine());

            // Cách 1

            Console.Write("Nhập lớp của bạn: ");

            int Class = System.Int32.Parse(Console.ReadLine());

            // Cách 2

            Console.Write("Nhâp điểm trung bình của bạn: ");

            float avgMark = Convert.ToSingle(Console.ReadLine());

            // float AvgMark = System.Single.Parse(Console.ReadLine());

            Console.WriteLine("Tên đầy đủ của bạn là: " + fullName);
            Console.WriteLine("Tuổi của bạn là: " + age);
            Console.WriteLine("Lớp của bạn là: " + Class);
            Console.WriteLine("Điểm trung bình của bạn là: " + avgMark);
            Console.ReadKey();
        }
    }
}
