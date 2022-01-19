using System;

namespace KeThua
{
    class Program
    {
        //Tính kế thừa
        //Khi thêm sealed thì ko thể kế thừa(niêm phong)
        class Animal
        {
            public int Legs { set; get; }
            public float Weight { set; get; }
            public void ShowLegs()
            {
                Console.WriteLine($"Legs: {Legs}");
            }
            public Animal(){
                System.Console.WriteLine("Khoi tao animal!!");
            }
            public Animal(string str){
                System.Console.WriteLine("Khoi tao animal!! (2) " + str);
            }
        }
        class Cat : Animal
        {
            public Cat( string str) : base(str)
            {
                this.Legs = 4;
                this.Food = "Mouse";
                this.ShowLegs();
            }
        
            public string Food;
            public void Eat()
            {
                Console.WriteLine($"Food: {this.Food}");
            }

            //Khởi tạo một phương thức giống tên của lớp cơ sở cần thêm từ khóa new
            public new void ShowLegs()
            {
               
                Console.WriteLine($"Loai meo co: {Legs} chan");
            }
            public void ShowInfo()
            {
                //Phương thức ShowLegs của lớp cơ sở Animal
                base.ShowLegs();
                
                //Phương thức ShowLegs của lớp kế thừa
                ShowLegs();

            }
        }
        static void Main(string[] args)
        {
            Cat c = new Cat("Hello");
            // c.ShowLegs();
            // c.Eat();
            c.ShowInfo();
            // c.ShowLegs();
            A a;
            B b = new B();
            C cc = new C();

            a = b;
            a = cc;

            // c = a; //Lớp kế thừa không thể khai báo bằng lớp cơ sở

            


        }
    }
}
