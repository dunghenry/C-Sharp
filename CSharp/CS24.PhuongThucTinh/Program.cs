using System;

namespace CS23.PhuongThucTinh
{
    class CountNumber{
        public static int number = 0;
        public static void Info(){
            Console.WriteLine("So lan truy cap la: " + number);
        }
        public void Count(){
            CountNumber.number++;
            // number++;
        }
    }

    class Student{
        public readonly string name; //Chỉ đọc

        public Student(string _name){
            this.name = _name;
        }

    }
   
    class Vecto{
        double x, y;
        public Vecto(double x, double y){
            this.x = x;
            this.y = y;
        }
        public void Info(){
            Console.WriteLine($"x = {x}, y = {y}");
        }

        public static Vecto operator+(Vecto v1, Vecto v2){
            //C1
            // return new Vecto(v1.x + v2.x, v1.y + v2.y);

            //C2
            double x = v1.x + v2.x;
            double y = v1.y + v2.y;
            Vecto v = new Vecto(x, y);
            return v;
        }
        public static Vecto operator+(Vecto v1, double value){
            //C1
            // return new Vecto(v1.x + v2.x, v1.y + v2.y);

            //C2
            double x = v1.x + value;
            double y = v1.y + value;
            Vecto v = new Vecto(x, y);
            return v;
        }

        public double this[int i]
        {
            set{
                switch(i)
                {
                    case 0:{
                        x = value;
                        break;
                    }
                    case 1:{
                        y = value;
                        break;
                    }   
                    default:{
                        throw new Exception("Chi so sai");  
                    }    
                }
            }
            get{
                 switch(i)
                {
                    case 0:{
                        return x;
                    }
                    case 1:{
                        return y;
                    }   
                    default:{
                        throw new Exception("Chi so sai");
                    }    
                }
            }
        }
        public double this[string s]
        {
            set{
                switch(s)
                {
                    case "x":{
                        x = value;
                        break;
                    }
                    case "y":{
                        y = value;
                        break;
                    }   
                    default:{
                        throw new Exception("Chi so sai");  
                    }    
                }
            }
            get{
                 switch(s)
                {
                    case "x":{
                        return x;
                    }
                    case "y":{
                        return y;
                    }   
                    default:{
                        throw new Exception("Chi so sai");
                    }    
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // CountNumber.Info();

            CountNumber c1 = new CountNumber();
            c1.Count();
            c1.Count();
            CountNumber.Info();

            Student s1 = new Student("Tran Van A");
            // s1.name = "Tran Van A"; //error
            Console.WriteLine(s1.name);

            Vecto vt1 = new Vecto(1, 3);
            Vecto vt2 = new Vecto(2, 4);
            vt1.Info();
            vt2.Info();
            var v3 = vt1 + vt2;
            v3.Info();

            double value = 1;
            Vecto v = v3 + value;
            v.Info();

            v[0] = 1;
            v[1] = 4;
            v.Info();

            v["x"] = 2;
            v["y"] = 5;
            v.Info();
        }
    }
}
