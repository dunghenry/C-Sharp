using System;
using Newtonsoft.Json;
using TranVanDung;
using System.Text;
namespace CS31.ThuVien
{
    class Program
    {   
        class Product{
            public string Name{set; get;}
            public DateTime Expiry{ set; get;}
            public string[] Sizes{ set; get;}
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Product product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime();
            product.Sizes = new string[] { "Small" };

            string json = JsonConvert.SerializeObject(product);
            // Console.WriteLine(json);
            
            string json1 = @"
            {
                ""Name"" : ""Dien thoai IP"",
                ""Expiry"" : ""0001-01-01T00:00:00"",
                ""Sizes"" : [""Large"", ""Small""]
            }
            ";

            var pr = JsonConvert.DeserializeObject<Product>(json1);
                // Console.WriteLine(pr.Sizes[0]);
                // Console.WriteLine(pr.Sizes[1]); 

        //dotnet add E:\CSharp-tutorial\CS31.ThuVien\CS31.ThuVien.csproj reference E:\CSharp-tutorial\Utils\Utils.csproj

        double a = 12345;
        var kq = ConvertMonneyToText.NumberToText(a);
        Console.WriteLine(kq);
        ConvertMonneyToText.Hello();
      
        }
    }
}
