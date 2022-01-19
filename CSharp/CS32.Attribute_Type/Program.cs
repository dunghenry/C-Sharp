using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace CS32.Attribute_Type
{
    class Program
    {
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
        class MotaAttribute : Attribute{
            public string Thongtinchitiet { get; set; }
            public MotaAttribute(string thongtintiet){
                Thongtinchitiet = thongtintiet;
            }
        }
        [Mota("Lop chua thong tin chi tiet tren he thong")]
        public class User{
                [Mota("Ten nguoi dung")]
                [Required(ErrorMessage = "Name phai thiet lap")]
                [StringLength(50, MinimumLength = 4, ErrorMessage = "Ten phai dai tu 4 den 50 ki tu")]
                public string Name { get; set; }
                [Mota("Tuoi nguoi dung")]
                [Range(18, 80, ErrorMessage = "Tuoi phai tu 18 den 80")]
                public int Age { get; set; }

                [Mota("So dien thoai nguoi dung")]
                [Phone(ErrorMessage = "So dien thoai khong dung")]
                public string PhoneNumber { get; set; }
                [Mota("Email nguoi dung")]
                [EmailAddress(ErrorMessage = "Email khong dung")]
                public string Email { get; set; }
        }
        static void Main(string[] args)
        {
            int a = 1;
            // Type t = typeof(int);
            //Console.WriteLine(t);
            //Console.WriteLine(a.GetType());
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9};

            Type t = arr.GetType();
            // t.GetProperties().ToList().ForEach(
            //     (PropertyInfo o) =>{
            //         Console.WriteLine(o.Name);
            //     }
            // );

            // Console.WriteLine("------------------------");
            // t.GetFields().ToList().ForEach(
            //     (FieldInfo o) =>{
            //         Console.WriteLine(o.Name);
            //     }
            // );

            // Console.WriteLine("------------------------");
            // t.GetMethods().ToList().ForEach(
            //     (MethodInfo o) =>{
            //         Console.WriteLine(o.Name);
            //     }
            // );

            User user = new User(){
                Name = "T",
                Age = 20,
                PhoneNumber = "12345678",
                Email = "trandungksnb00@gmail.com"
            };

            // var properties = user.GetType().GetProperties();
            // foreach (PropertyInfo property in properties)
            // {
            //     string name = property.Name;
            //     var value = property.GetValue(user);
            //     Console.WriteLine($"{name} {value}");
            // }

            // var properties = user.GetType().GetProperties();
            // foreach (PropertyInfo property in properties)
            // {
                
            //    foreach (var attr in property.GetCustomAttributes(false))
            //    {
            //        MotaAttribute mota = attr as MotaAttribute;
            //        if(mota != null){
            //            var name =  property.Name;
            //            var value = property.GetValue(user);
            //            Console.WriteLine($"{name} : {mota.Thongtinchitiet} : {value}");
            //         }
            //    }
            // }

            ValidationContext context = new ValidationContext(user);
            var result = new List<ValidationResult>();
            bool kq = Validator.TryValidateObject(user, context, result, true);
            if(kq == false){
                result.ToList().ForEach(er =>{
                    Console.Write(er.MemberNames.First() + "\t");
                    Console.Write(er.ErrorMessage);
                });
            }

        }
    }
}
