using System;

namespace Struct
{
    class Program
    {
        //Struct
        public struct Product{
            //dl
            public string name;
            public double price;
            public string GetInfo(){
                return $"Ten san pham {name}, gia: {price}";
            }

            //Constructor

            public Product(string name, double price){
                this.name = name;
                this.price = price;
            }

            public string Info(){
                return $"{name} {price}";
            }

        }
       
        //enum Product

        enum HocLuc{
            Kem, //0
            TrungBinh, //1
            Kha, //2
            Gioi //3
            }
        static void Main(string[] args)
        {
            Product sp;
            sp.name = "IPhone 7";
            sp.price = 2000;
            System.Console.WriteLine(sp.GetInfo());

            //Constructor
            Product Nokia = new Product("Nokia", 3000);
            System.Console.WriteLine(Nokia.GetInfo());
            System.Console.WriteLine(Nokia.name);
            System.Console.WriteLine(Nokia.Info());

            //struct tham trị
            //class la tham chiếu
            
            // ! enum 
            HocLuc hocluc;
            hocluc = HocLuc.Gioi;
            //Chuyển từ học lực sang số
            int so = (int)hocluc;
            System.Console.WriteLine(so);

            //Chuyển từ số sang học lực

            hocluc = (HocLuc)(1);


            switch (hocluc)
            {
                case HocLuc.Kem:
                        System.Console.WriteLine("Hoc luc kem");
                    break;
                case HocLuc.TrungBinh:
                        System.Console.WriteLine("Hoc luc trung binh");
                    break;
                case HocLuc.Kha:
                        System.Console.WriteLine("Hoc luc kha");
                    break;
                case HocLuc.Gioi:
                        System.Console.WriteLine("Hoc luc gioi");
                    break;
                default:
                    System.Console.WriteLine("Khong hop le");
                    break;
            }
            

        }
    }
}
