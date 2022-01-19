namespace inputKeyboard
{
    public class String
    {
        static void Main(){
            string str = "        Hello World";
            System.Console.WriteLine(str);
            // Đếm kí tự
            System.Console.WriteLine(str.Length);
            // Đổi thành chữ in hoa
            System.Console.WriteLine(str.ToUpper());
            // !Đổi thành chữ thường
            System.Console.WriteLine(str.ToLower());
            // ! Bỏ khoảng trắng
            System.Console.WriteLine(str.Trim());
            // Tìm kiếm
            System.Console.WriteLine(str.Contains("a"));
            // Tìm kiếm kí tự đầu tiên
            System.Console.WriteLine(str.IndexOf("o"));
            // Tìm kiếm tự cuối cùng
            System.Console.WriteLine(str.LastIndexOf("o"));
        }
    }
}