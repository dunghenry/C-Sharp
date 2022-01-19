namespace Sanpham{
    public partial class Product{
        public string Description { get; set;}
        public class Manufactore{
            public string name { get; set;}
            public string address { get; set;}
        }
        public Manufactore manufactore{ get; set;}

    }
}