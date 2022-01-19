using System.IO;
using System;
using System.Text;
namespace CS28.File_P2
{
    class Program
    {
        class Product{
            public int ID{set; get;}
            public double Price{set; get;}
            public string Name{set; get;}
            public void Save(Stream stream){
                // int -> 4byte
                var bytes_id = BitConverter.GetBytes(ID);
                stream.Write(bytes_id, 0, 4);

                // double -> 8byte
                var bytes_price = BitConverter.GetBytes(Price);
                stream.Write(bytes_price, 0, 8);
                
                var bytes_name = Encoding.UTF8.GetBytes(Name);
                var bytes_length = BitConverter.GetBytes(bytes_name.Length);
                stream.Write(bytes_length, 0, 4);
                stream.Write(bytes_name, 0, bytes_name.Length);

            }
            public void Restore(Stream stream){
                var bytes_id = new byte[4];
                stream.Read(bytes_id, 0 , 4);
                ID = BitConverter.ToInt32(bytes_id, 0);

                var bytes_price = new byte[8];
                stream.Read(bytes_price, 0 , 8);
                Price = BitConverter.ToDouble(bytes_price, 0);
            }
        }
        static void Main(string[] args)
        {
            var path = "data.txt";
            using var stream = new FileStream(path: path, FileMode.Open);
            // byte[] buffer = {1, 2, 3};

            // //Lưu dữ liêu
            // int offset = 0;
            // int count = 3;
            // stream.Write(buffer, offset, count);

            // //Đọc dl
            // stream.Read(buffer, offset, count);

            // //int, double --> byte

            // int abc = 1;
            // var bytes_abc = BitConverter.GetBytes(abc);

            // // byte --> int, double
            // BitConverter.ToInt32(bytes_abc, 0);

            // string s = "Abc";
            // var bytes_s = Encoding.UTF8.GetBytes(s);
            // Encoding.UTF8.GetString(bytes_s, 0, 10);

            Product product = new Product(){
                ID = 123,
                Price = 2000,
                Name = "IphoneX",
            };
            // product.Save(stream);
            product.Restore(stream);
            Console.WriteLine($"{product.Name}- {product.ID}- {product.Price}");
           
        }
    }
}
