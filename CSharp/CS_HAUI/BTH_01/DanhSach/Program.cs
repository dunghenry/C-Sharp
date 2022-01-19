using System;
using System.Collections.Generic;
namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Double> DS = DSST.SoThuc();
            //Sắp xếp tăng dần
            DS.Sort();
            Console.Write("Sap xep tang dan: \t");
            foreach (var item in DS)
            {
                Console.Write($"{item} \t");
            }
            for (int i = 0; i < DS.Count; i++)
            {
                if (DS[i] < 0)
                    DS.Remove(DS[i]);

            }
            for (int i = 0; i < DS.Count; i++)
            {
                Console.WriteLine(DS[i]);
            }
          
        }
        class DSST
        {
            public static List<Double> SoThuc()
            {
                List<Double> DS = new List<Double>();
                string luachon = "";
                while (luachon != "N")
                {
                    Console.Write("\nNhap vao mot so thuc bat ki: ");
                    DS.Add(double.Parse(Console.ReadLine()));
                    Console.Write("\nNhap n de ket thuc!");
                    luachon = Console.ReadLine().ToUpper();
                }
                return DS;
            }
        }
    }
    
}
