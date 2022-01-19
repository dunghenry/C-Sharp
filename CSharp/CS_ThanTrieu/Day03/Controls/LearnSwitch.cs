using System;
using System.Text;
namespace Controls
{
    public class LearnSwitch
    {
        static void Main(){
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            System.Console.Write("Nhập bất kì một số nguyên ");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());
            switch (dayOfWeek)
            {
                case 1:
                    {
                        System.Console.WriteLine("Hom nay la thu hai");
                        break;
                    }
                case 2:
                    {
                        System.Console.WriteLine("Hom nay la thu ba");
                        break;
                    }
                case 3:
                    {
                        System.Console.WriteLine("Hom nay la thu tu");
                        break;
                    }
                case 4:
                    {
                        System.Console.WriteLine("Hom nay la thu nam");
                        break;
                    }
                case 5:
                    {
                        System.Console.WriteLine("Hom nay la thu sau");
                        break;
                    }
                case 6:
                    {
                        System.Console.WriteLine("Hom nay la thu bay");
                        break;
                    }
                case 7:
                    {
                        System.Console.WriteLine("Hom nay la chu nhat");
                        break;
                    }
                default:
                    System.Console.WriteLine("Lua chon khong hop le");
                    break;
            }
            
        }
    }
}