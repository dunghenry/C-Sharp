using System;

namespace Null_NullAble
{
    class Abc{
        public void XinChao() => Console.WriteLine("Xin chao C#");
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Error
            Abc a = null;
            // a.XinChao();

            Abc b = new Abc();
            if(b != null)
                b.XinChao();

            a?.XinChao();

            //NullNullAble
            int age;

            // age = null; Error

            int? Age;
            Age = null; //Success
            Age = 100; 

            if(Age.HasValue){
                int _Age = Age.Value;
                System.Console.WriteLine(_Age);
            }
            if(Age != null){
                // int _Age = Age.Value;
                int _Age = (int)Age;
                System.Console.WriteLine(_Age);
            }
        }
    }
}
