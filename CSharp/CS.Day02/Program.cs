using System;

namespace CSharp_basic02
{
    class Program
    {
        static void Main(string[] args)
        {
            Vukhi Sungluc;
            Sungluc = new Vukhi();
            //Hello helloFullName;
            //helloFullName = new Hello("Tran Van Dung");
            //Console.WriteLine(Sungluc.name);
            Sungluc.name = "Sung luc";
            Sungluc.doSatThuong(5);
            Sungluc.tanCong();
            Vukhi Sungmay;
            Sungmay = new Vukhi("Sung may", 10);
            Sungmay.tanCong();
            Console.WriteLine(Sungluc.Satthuong);
            Sungluc.Noisanxuat = "VietNam";
            Console.WriteLine(Sungluc.Noisanxuat);
            Student student;
            for (int i = 0; i < 100000; i++)
            {
                student = new Student("Sinh vien thu " + i);
                student = null;
            }
            
        }
        class Student
        {
            string name;
            public Student(string name)
            {
                this.name = name;
                Console.WriteLine("Khoi tao " + name);
            }
            ~Student(){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Huy " + name);
                Console.ResetColor();
            }
        }
    }
}
