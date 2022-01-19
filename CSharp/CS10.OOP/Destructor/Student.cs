using System;
using System.Collections.Generic;
using System.Text;

namespace Destructor
{
    public class Student : IDisposable
    {
        public string name;
        public Student(string name)
        {
            this.name = name;
            Console.WriteLine("Khoi tao " + name);
        }

        ~Student()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Huy thanh cong");

            Console.ResetColor();
        }

        public void Dispose()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Huy thanh cong boi dispose!!");

            Console.ResetColor();
        }
    }
    
}
