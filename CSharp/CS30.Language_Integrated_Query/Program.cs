using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace CS30.Language_Integrated_Query
{
    public class Product{
        public int ID{set; get;}
        public string Name{ set; get;}
        public double Price{ set; get;}
        public string[] Colors{ set; get;}
        public int Brand{ set; get;}
        public Product(int id, string name, double price, string[] color, int brand){
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Colors = color;
            this.Brand = brand;
        }
        override public string ToString() => $"{ID, 3}  {Name, 15}  {Price, 5}  {string.Join(",", Colors)}  {Brand, 10}";
    }
    public class  Brand {
        public string Name {set; get;}
        public int ID {set; get;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Product product = new Product(123, "IPX", 2000, new string[] {"Xanh", "Do"}, "Apple");
            // Console.WriteLine(product.ToString());
            Console.OutputEncoding = Encoding.Unicode;

            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
            };

            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };
            // foreach (var item in brands)
            // {
            //     Console.WriteLine($"{item.ID} - {item.Name}");
            // }

            //? Truy vấn cơ bản

            // var query = from p in products
            //             where p.Price == 400
            //             select p;
            // foreach (var item in query){
            //     Console.WriteLine(item);
            // }

            //! Seclect
            // var kq = products.Select(
            //     (p) =>{
            //         return p.Name;
            //     }
            // );

            // var kq = products.Select(
            //     (p) =>{
            //         return p.Price;
            //     }
            // );

            // var kq = products.Select(
            //     (p)=>{
            //         return new {
            //             Ten = p.Name,
            //             Gia = p.Price
            //         };
            //     }
            // );
            // foreach (var item in kq)
            // {
            //     Console.WriteLine(item);
            // }

            //TODO Where

            // var kq = products.Where(
            //     (p) =>{
            //         return p.Name.Contains("tr");
            //     }
            // );
            // var kq = products.Where(
            //     (p) =>{
            //         return p.Brand == 2;
            //     }
            // );
            // foreach (var item in kq)
            // {
            //     Console.WriteLine(item);
            // }

            //! SelectMany

            // var color = products.SelectMany(
            //     (p) =>{
            //         return p.Colors;
            //     }
            // );
            // foreach (var item in color){
            //     Console.WriteLine(item);
            // }

            //? Min , max, sum, average

            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            // Console.WriteLine(numbers.Max());
            // Console.WriteLine(numbers.Min());
            // Console.WriteLine(numbers.Sum());
            // Console.WriteLine(numbers.Average());
            // Console.WriteLine(numbers.Where(n => n % 2 == 0).Max());
            // Console.WriteLine(products.Min(p =>p.Price));
            // Console.WriteLine(products.Average(p =>p.Price));

            //! Join

            // var kq = products.Join(brands, p => p.Brand, b => b.ID, (p, b)=>{
            //     return new{
            //         Tensanpham = p.Name,
            //         Thuonghieu = b.Name
            //     };
            // });

            // foreach (var item in kq){
            //     Console.WriteLine(item);
            // }

            //TODO GroupJoin

            // var kq = brands.GroupJoin(products, b => b.ID, p => p.Brand, 
            //     (brand, pros) =>{
            //         return new{
            //             Thuonghieu = brand.Name,
            //             Cacsanpham = pros

            //         };
            //     }
            // );

            // foreach(var gr in kq){
            //     Console.WriteLine(gr.Thuonghieu);
            //     foreach (var item in gr.Cacsanpham){
            //         Console.WriteLine(item);
            //     }
            // }
            
            //! Takes

            //products.Take(3).ToList().ForEach(p => Console.WriteLine(p)); // Lấy ra 3 phần tử đầu của products

            //? Skip

            //products.Skip(2).ToList().ForEach(p => Console.WriteLine(p)); // Bỏ qua 2 phần tử đầu của products

            //! Orderby / OrderbyDescending

            // products.OrderBy(p =>p.Price).ToList().ForEach(p => Console.WriteLine(p));

            // products.OrderByDescending(p =>p.Price).ToList().ForEach(p => Console.WriteLine(p));

            //? Reverse(đảo ngược mảng) // .ForEach có sẵn trong .ToList()

            // numbers.Reverse().ToList().ForEach(num => Console.WriteLine(num));

            //Todo GroupBy

            // var kq = products.GroupBy(p => p.Price);
            // foreach (var group in kq){
            //     Console.WriteLine(group.Key);
            //     foreach(var item in group){
            //         Console.WriteLine(item);
            //     }
            // }

            // var kq1 = products.GroupBy(p => p.Brand);
            // foreach(var group in kq1){
            //     Console.WriteLine(group.Key);
            //     foreach(var i in group){
            //         Console.WriteLine(i);
            //     }
            // }

            // Distinct

            //products.SelectMany(p => p.Colors).Distinct().ToList().ForEach(p => Console.WriteLine(p));

            // ! Single
            // var p = products.Single(p => p.Price == 500);
            // Console.WriteLine(p);

            // var p = products.SingleOrDefault(p => p.Price == 1000);
            // if (p != null)
            //     Console.WriteLine(p);
                
            // ? Any true/false
            // var p = products.Any(p => p.Price == 700);
            // Console.WriteLine(p);

            // ! All
            // var p = products.All(p => p.Price >= 300);
            // Console.WriteLine(p);

            //Count 

            // var p = products.Count();
            // Console.WriteLine(p);

            // var p = products.Count(p => p.Price >= 300);
            // Console.WriteLine(p);

            //? In ra tên sản phẩm, tên thương hiệu có giá từ 300 - 400
            //? Sắp xếp theo giá giảm dần

            // products.Where(p => p.Price >= 300 && p.Price <= 400)
            //         .OrderByDescending(p => p.Price)
            //         .Join(brands, p => p.Brand, b => b.ID, (sp, th)=>{
            //             return new{
            //                 TenSP = sp.Name,
            //                 Thuonghieu = th.Name,
            //                 GiaSP = sp.Price
            //             };
            //         })
            //         .ToList()
            //         .ForEach(info => {
            //             Console.WriteLine($"{info.TenSP, 15} {info.Thuonghieu, 15} {info.GiaSP}");
            //         });

            // var qr = from p in products 
            //         // select p.Name
            //         // select $"{p.Name} {p.Price}";
            //         select new{
            //             TenSP = p.Name,
            //             GiaSP = p.Price,
            //             Dulieu = "Abc..."
            //         };

            // qr.ToList().ForEach(p =>{
            //     Console.WriteLine(p);
            // });

            // var qr = from p in products
            //         where p.Price == 400
            //         select p;
            
            //  foreach (var item in qr) {
            //     Console.WriteLine(item);
            // }

            // var qr = from p in products
            //          from color in p.Colors
            //         where p.Price <= 400 && color == "Xanh"
            //         orderby p.Price //descending
            //         select new{
            //             TenSP = p.Name,
            //             GiaSP = p.Price,
            //             CacMauSac = p.Colors
            //         };
            
            //  foreach (var item in qr) {
            //     Console.WriteLine($"{item.TenSP} - {item.GiaSP} - {string.Join(",", item.CacMauSac)}");
            // }

            // var qr = from p in products
            //         group p by p.Price;
            
            // qr.ToList().ForEach(gr =>{
            //     Console.WriteLine(gr.Key);
            //     gr.ToList().ForEach(item => Console.WriteLine($"{item}"));
            // });

            // var qr = from p in products
            //         group p by p.Price into gr
            //         orderby gr.Key
            //         select gr;
            
            // qr.ToList().ForEach(gr =>{
            //     Console.WriteLine(gr.Key);
            //     gr.ToList().ForEach(item => Console.WriteLine($"{item}"));
            // });
            
            // var qr = from p in products
            //         group p by p.Price into gr
            //         orderby gr.Key
            //         let sl = "So luong la: " + gr.Count()
            //         select new{
            //             Gia = gr.Key,
            //             Cacsanpham = gr.ToList(),
            //             Soluong = sl,

            //         };
            
            // qr.ToList().ForEach(i =>{
            //     Console.WriteLine(i.Gia);
            //     Console.WriteLine(i.Soluong);
            //     i.Cacsanpham.ForEach(sp => Console.WriteLine(sp));
            // });
            
            // var query = from product in products
            //             join brand in brands on product.Brand equals brand.ID
            //             select new{
            //                 TenSP = product.Name,
            //                 gia = product.Price,
            //                 thuonghieu = brand.Name,
            //             };
            
            // query.ToList().ForEach(o =>{
            //     Console.WriteLine($"{o.TenSP}  {o.gia} {o.thuonghieu}");
            // });

            var query = from product in products
                        join brand in brands on product.Brand equals brand.ID into t
                        from b in t.DefaultIfEmpty()
                        select new{
                            TenSP = product.Name,
                            gia = product.Price,
                            thuonghieu = (b != null) ? b.Name : "No Brand"
                        };
            
            query.ToList().ForEach(o =>{
                Console.WriteLine($"{o.TenSP}  {o.gia} {o.thuonghieu}");
            });

        }
    }
}
