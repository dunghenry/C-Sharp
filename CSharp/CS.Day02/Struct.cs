using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic02
{
    class Struct
    {
        public struct Product
        {
            //dữ liệu
           
            public string name;
            public double price;
            //phương thức
            public string getInfor()
            {
                return $"Ten san pham {this.name}";
            }
            //constructer
            public Product(string _name, double _price)
            {

                this.name = _name;
                this.price = _price;
            }
        }
        static void Main()
        {
            Product sp1;
            sp1.name = "Jean";
            sp1.price = 100;
            Product sp2 = new Product("Iphone", 10000);
            Console.WriteLine(sp1.getInfor());
            Console.WriteLine(sp2.getInfor());

        }
    }
}
