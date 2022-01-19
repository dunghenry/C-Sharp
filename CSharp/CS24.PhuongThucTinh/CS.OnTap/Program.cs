using System;
namespace CS.OnTap
{
    public class CountNumber {
        public static int count = 0;
        public static void Info(){
            Console.WriteLine("So lan truy cap la: " + count);
        }
        public void Count(){
            // CountNumber.count++;
            CountNumber.count++;
        }
    }
    class Student{
         public readonly string name = "Tran Van A";
        // public readonly string name;
        public Student(string _name){
            this.name = _name;
        }
        public Student(){
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CountNumber num1 = new CountNumber();
            CountNumber num2 = new CountNumber();
            num1.Count();
            CountNumber.Info();

            Student student = new Student();
            Console.WriteLine(student.name);

            //student.name = "Student"; // Ko đc gán chỉ đc đọcx

            Vector x = new Vector(2, 3);
            Vector y = new Vector(3, 5);

            x.Info();
            y.Info();

            Vector z;

            z = x + y;
            z.Info();  // x = 5, y = 8
            Vector k = x + 10;
            k.Info(); // x = 12, y = 13

            Vector v = new Vector(1, 1);
            v[0] = 5;
            v[1] = 10;
            v.Info(); // x = 5, y = 20
            //Console.WriteLine(v[2]); // Chi so sai

            Vector e = new Vector(2, 4);
            e["toadox"] = 10;
            e["toadoy"] = 20;
            e.Info(); // x = 10, y = 20
            
        }
    }
}
