using System;
using System.Text;
using System.IO;
using MyExpectations;
namespace CS25Exception
{
    class Program
    {
        static void Register(string name, int age){

            if(string.IsNullOrEmpty(name)){
                // Exception exception = new Exception("Ten phai khac rong??");
                // throw exception;
                throw new NameEmtyException();

            }
            if(age < 18 || age > 100){
                throw new AgeException(age);
            }
            Console.WriteLine($"Xin chao {name} - {age}");
        }
        static void Main(string[] args)
        {
           int a = 5;
           int b = 2;
           try
           {
                int c = a / b;
                Console.WriteLine("Ket qua la: " + c);

                int[] arr = {1, 2, 3};
                var x = arr[3];
           }
        //    catch(Exception e)
        //    {
              
        //         Console.ForegroundColor = ConsoleColor.Red;
        //         Console.WriteLine(e.Message);
        //         Console.WriteLine(e.GetType().Name);
        //         System.Console.WriteLine("Error");
        //         Console.ResetColor();
        //    }
           catch(DivideByZeroException e){
               Console.WriteLine(e.Message);
               System.Console.WriteLine("Khong duoc chia cho 0 haha???");
           }
            catch(IndexOutOfRangeException e2){
               Console.WriteLine(e2.Message);
               Console.WriteLine("Chi so mang khong ton tai! Kaka");
           }
           catch(Exception e1){
               Console.WriteLine(e1.Message);
           }
          
           Console.WriteLine("Ket thuc!!");


           string path = "1.txt";
        //    string path  = null;

           try{
                string s = File.ReadAllText(path);
                Console.WriteLine(s);
           }
           catch(ArgumentException ane){
               Console.WriteLine(ane.Message);
               Console.WriteLine("Duong dan phai khac null");
               
           }
           catch(FileNotFoundException fnfe){
               Console.WriteLine(fnfe.Message);
               Console.WriteLine("Khong ton tai file da chon");
           }
           catch(Exception e3){
               Console.WriteLine(e3.Message);
           }
           
           try
           {
                Register("aa", 10);
               
           }
           catch(NameEmtyException nee){
               Console.WriteLine(nee.Message);
           }
           catch (AgeException e5)
           {
               Console.WriteLine(e5.Message);
               e5.Detail();
           }

          
        }
    }
}
