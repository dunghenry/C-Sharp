using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Vehicle> li = new List<Vehicle>();
            do
            {
                Console.WriteLine("============MAIN MENU================");
                Console.WriteLine("1. Nhập dữ liệu");
                Console.WriteLine("2. Hiển thị dữ liệu");
                Console.WriteLine("3. Tìm kiếm theo id");
                Console.WriteLine("4. Tìm kiếm theo maker");
                Console.WriteLine("5. Sắp xếp theo price");
                Console.WriteLine("6. Sắp xếp theo năm sản xuất");
                Console.WriteLine("7. Kết thúc");
                Console.Write("Choice: ");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        li.Add(new Car("veh1", "Mercedes", "BMW Serie 5", 2017, 2000, "blue"));
                        li.Add(new Car("veh2", "Mercedes", "Audi A6", 2019, 2500, "white"));
                        li.Add(new Car("veh3", "Honda", "Honda Civic", 2018, 1200, "gray"));
                        li.Add(new Truck("veh4", "Hyundai", "New Mighty N250", 2016, 2200, 3));
                        li.Add(new Truck("veh5", "Hyundai", "New Mighty 110s", 2015, 1500, 7));
                        li.Add(new Truck("veh6", "Isuzu", "QKR77FE4", 2017, 3000, 2));
                        break;
                    case 2:
                        foreach (var item in li)
                        {
                            item.Output();
                        }
                        break;
                    case 3:
                        Console.Write("Nhập id cần tìm kiếm:"); string id = Console.ReadLine();
                        Vehicle v = new Vehicle(id); int index = li.IndexOf(v);
                        if (index != -1)
                        {
                            Console.WriteLine("Tìm thấy id: " + li[index]);
                        }
                        else
                        {
                            Console.WriteLine("--> Không có id " + id + "trong danh sách");
                        }
                        break;
                    case 4:
                        Console.Write("Nhập maker cần tìm kiếm:");
                        string m = Console.ReadLine();
                        List<Vehicle> li2 = new List<Vehicle>();

                        foreach (var item in li)
                        {
                            if (item.maker.Equals(m))
                            {
                                li2.Add(item);
                            }

                        }
                        if (li2.Count > 0)
                        {
                            Console.WriteLine("Tìm thấy maker: "); foreach (var item in li2)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("---> Không có xe nào như vậy ");

                        }
                        break;
                    case 5:
                        Console.WriteLine("\n=== Danh sach truoc khi sap xep === ");
                        var header = String.Format("{0,-8}{1,-10}{2,-25}{ 3,10}{ 4,10}", "ID", "MAKER", "MODEL", "YEAR", "PRICE");
                        Console.WriteLine(header);

                        foreach (var item in li)
                        {
                            Console.WriteLine(item);
                        }
                        li.Sort();
                        Console.WriteLine("\n=== Danh sach sau khi sap xep theo price === ");

                        foreach (var item in li)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 6:
                        Console.WriteLine("\n=== Danh sach truoc khi sap xep === ");
                        var header2 = String.Format("{0,-8}{1,-10}{2,-25}{ 3,10}{ 4,10}", "ID", "MARKER", "MODEL", "YEAR", "PRICE");
                        Console.WriteLine(header2);

                        foreach (var item in li)
                        {
                            Console.WriteLine(item);
                        }
                        li.Sort(new CompareYear());
                        Console.WriteLine("\n=== Danh sach sau khi sap xep theo year === ");

                        foreach (var item in li)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                }
            } while (opt != 7);
        }
    }
}
