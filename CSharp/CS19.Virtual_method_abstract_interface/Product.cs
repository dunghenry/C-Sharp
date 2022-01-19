using System;
namespace  Virtual_method_abstract_interface{

    //virtual
    //abstract chi lm lop co so cho ke thua
    
    public abstract class Product{
        protected double Price{ get; set; }

        //virtual
        // public virtual void ProductInfo(){
        //     System.Console.WriteLine($"Gia san pham la: {Price}");
        // }

        //abstract bắt buộc phải nạp chồng
        public abstract void ProductInfo();
        public void Test() => ProductInfo();
       

    }
    
 }