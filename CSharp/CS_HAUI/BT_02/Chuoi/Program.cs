using System;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap mot chuoi bat ki: ");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
               Console.WriteLine(str[i]);
            }
            Console.Write("Nhap chuoi thu hai: ");
            string str2 = Console.ReadLine();
            string[] str3 = str2.Split(" ");
            foreach (var item in str3)
            {
                Console.WriteLine(item);
            }
            Console.Write("Nhap chuoi cuoi cung: ");
            string lastStr = Console.ReadLine();
            lastStr = lastStr.Replace(" ", string.Empty);
            while(lastStr.Length > 0)
            {
                Console.Write(lastStr[0] + " : ");
                int count = 0;
                for (int j = 0; j < lastStr.Length; j++)
                {
                    if (lastStr[0] == lastStr[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                lastStr = lastStr.Replace(lastStr[0].ToString(), string.Empty);
            }
            Console.WriteLine(lastStr);
            
            
        }
    }
}
