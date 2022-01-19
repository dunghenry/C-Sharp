using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basic02
{
    class Enum
    {
        enum HocLuc
        {
            Kem,//0
            TrungBinh,//1
            Kha,//2
            Gioi//3
        }
        //có thể gán trực tiếp cho học lực = 
        static void Main()
        {
            HocLuc hocluc;
            hocluc = HocLuc.Gioi;
            switch (hocluc)
            {
                case HocLuc.Kem:
                        Console.WriteLine("Hoc luc kem");
                    break;
                case HocLuc.TrungBinh:
                    Console.WriteLine("Hoc luc trung binh");
                    break;
                    Console.WriteLine("Hoc luc kha");
                case HocLuc.Kha:
                    break;
                case HocLuc.Gioi:
                    Console.WriteLine("Hoc luc gioi");
                    break;
                default:
                    Console.WriteLine("No");
                    break;
            }
        }
    }
}
