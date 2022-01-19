using System;

namespace Destructor
{
    class Program
    {
        static void Test()
        {
            using Student sv = new Student("AAA");
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);


        }
        static void Main(string[] args)
        {
            //Student student;
            // for (int i = 0; i < 100000; i++)
            // {
            // student = new Student("SINH VIEN THU" + i);
            // student = null;
            // }
            Test();
            using (Student s = new Student("Ten sinh vien"))
            {

            }
        }
    }
}
