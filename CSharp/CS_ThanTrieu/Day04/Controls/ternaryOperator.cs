namespace Controls
{
    public class ternaryOperator
    {
        static void Main(){
            int a = 10, b = 20;
            int time = 12;
            string str = default;
            bool c = (a > b) ? true : false;
            if(time < 12){
                str = "Hello";
            }
            else{
                str = "Goodbye";
            }
            str = (time < 12) ? "Hello" : "Goodbye";
            System.Console.WriteLine(c);
            System.Console.WriteLine(str);
            System.Console.WriteLine(str);
        }
    }
}