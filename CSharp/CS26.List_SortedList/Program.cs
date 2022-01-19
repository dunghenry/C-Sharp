using System;
using System.Collections.Generic;
namespace CS26List_SortedList
{
    
    class Program
    {
        class Product{
            public string name {set; get;}
            public double price{ set; get;}
            public int id { set; get;}
            public string origin{ set; get;}
           
        }
        static void Main(string[] args)
        {
            // List<int> ds1 = new List<int>();
            // List<string> ds2;
            // ds1.Add(1);
            // ds1.Add(2);
            // ds1.Insert(0, 10); // Chèn số 10 vào vt 0
            // ds1.RemoveAt(2); //Xóa phần tử có gt = 2
            // ds1.AddRange(new int[] {3, 4, 5});
            // ds1.Remove(3); //Xóa phần tử có gt = 3 đầu tiên
            // Console.WriteLine(ds1.Count);
            // foreach (var item in ds1)
            // {
            //     Console.Write(item + " ");
            // }

            //ds1.InsertRange() // Chèn 1 mảng
            //ds1.RemoveAll() //Xóa tất cả các phần tử
            //ds1.Clear() //Xóa tất cả các phần tử

            //Tìm kiếm

            // var n = ds1.Find(
            //     (x) =>{
            //         return x % 2 == 0;
            //     }
            // );
            //  Console.WriteLine();
            // Console.WriteLine(n);

            // var m = ds1.FindAll(
            //     (x) =>{
            //         return x % 2 == 0;
            //     }
            // );
            // foreach (var item in m)
            // {
            //     Console.Write(item + " ");
            // }

            //!
            List<Product> dsSP = new List<Product>(){
                new Product{name = "IphoneX", price = 1200, id = 001, origin = "China"},
                new Product{ name = "Iphone12", price = 2000, id = 002, origin = "VN"},
                new Product{ name = "Realme C2", price = 1500, id = 003, origin = "China"},
                new Product{ name = "Nokia", price = 800, id = 004, origin = "China"},
            };

            // string name, origin;
            // double price;
            // int id;
            // Console.Write("Nhap ten san pham: ");
            // name = Console.ReadLine();
            // Console.Write("Nhap gia san pham: ");
            // price = double.Parse(Console.ReadLine());
            // Console.Write("Nhap id san pham: ");
            // id = int.Parse(Console.ReadLine());
            // Console.Write("Nhap nguon goc san pham: ");
            // origin = Console.ReadLine();

           
            // foreach (var item in dsSP)
            // {
            //     Console.Write(item.name + "\t");
            // }

            Console.WriteLine("----------------------------");
            //Sắp xếp giảm dần theo giá
            dsSP.Sort(
                (p1, p2) =>{
                    if(p1.price == p2.price) return 0;
                    if(p1.price < p2.price) return 1;
                    return -1;
                }
            );

            foreach (var item in dsSP){
                Console.WriteLine($"{item.name} - {item.price} - {item.origin}");
            }

            Console.WriteLine("----------------------------");
            dsSP.Sort(
                (p1, p2) =>{
                    if(p1.price == p2.price) return 0;
                    if(p1.price < p2.price) return -1;
                    return 1;
                }
            );

            foreach (var item in dsSP){
                Console.WriteLine($"{item.name} - {item.price} - {item.origin}");
            }

            //Liệt kê sản phẩm có price > 1000

            var ds = dsSP.FindAll(
                (x) =>{
                    return x.price > 1000;
                }
            );
            foreach (var item in ds)
            {
                Console.WriteLine($"{item.name} - {item.price} - {item.origin}");
            }

            SortedList<string, Product> products = new SortedList<string, Product>();
            products["sp1"] = new Product(){name = "IpX", price = 1000, id = 111, origin = "China"};
            products.Add("sp2", new Product(){name = "Ip13", price = 1000, id = 001, origin = "VN"});

            var p = products["sp2"];
            Console.WriteLine(p.name);


            var keys = products.Keys;
            var values = products.Values;
            Console.WriteLine("Cac key --------");
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("Cac value --------");
            foreach (var value in values)
            {
                Console.WriteLine(value.name);
            }

            Console.WriteLine("Cach hai ----------------------");

            foreach (KeyValuePair<string, Product> item in products) {
                var key = item.Key;
                var value = item.Value;
                Console.WriteLine($"{key}-{value.name}");
            }

            // products.Remove("sp1");
            // products.RemoveAt(0);
            // products.Clear();
           
        }
    }
}
