using System;
using System.Collections.Generic;
using System.Linq;
public class Product{
    public string ID {set; get;}
    public string Name {set; get;}
    public double Price {set; get;}
}
public class ProductServices{
    List<Product> products = new List<Product>();
    public ProductServices(){
        Console.WriteLine("Khoi tao Product Services");
        products.AddRange(new Product[]{
            new Product(){ID = "SP01", Name = "Điện thoại Iphone 7 Plus", Price = 2000},
            new Product(){ID = "SP02", Name = "Điện thoại i Samsung", Price = 1000},
            new Product(){ID = "SP03", Name = "Laptop Lenovo", Price = 5000},
            new Product(){ID = "SP04", Name = "Ipad Samsung", Price = 2000},
        });
    }
    public Product FindProduct(string productID){
        var query = from p in products 
                    where p.ID == productID
                    select p;

        return query.FirstOrDefault(); //Nếu có lấy ra phần tử đầu tiên nếu ko thì trả về null
    }
}