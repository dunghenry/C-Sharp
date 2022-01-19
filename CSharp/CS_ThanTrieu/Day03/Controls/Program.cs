using System;

namespace Controls
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = 1;
            if(dayOfWeek < 5){
                System.Console.WriteLine("I have go to school!");
            }
            else{
                System.Console.WriteLine("Weekend");
            }

            int dayOfWeekTwo = 10;
            if(dayOfWeekTwo == 1){
                System.Console.WriteLine("Monday");
            }
            else if(dayOfWeekTwo == 2){
                System.Console.WriteLine("Tuesday");
            }
            else if(dayOfWeekTwo == 2){
                System.Console.WriteLine("Wednesday");
            }
            else{
                System.Console.WriteLine("Other day");
            }
        }
    }
}
