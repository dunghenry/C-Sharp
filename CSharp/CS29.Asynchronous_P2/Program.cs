using System.Net.Http;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
namespace CS29.Asynchronous_P2
{
    class Program
    {
        static void DoSomething(int seconds, string message, ConsoleColor color){
           
           lock(Console.Out){
                Console.ForegroundColor = color;
                Console.WriteLine($"{message, 10}... Start");
                Console.ResetColor();
            }

             //!
            string str = "abc";
            lock (str)
            {
                //
            }

            for (int i = 0; i <= seconds; i++){

                lock(Console.Out){
                    Console.ForegroundColor = color;
                    Console.WriteLine($"{message, 10} {i, 2}");
                    Console.ResetColor();
                }
               
                Thread.Sleep(1000);
            }
            lock(Console.Out){
                Console.ForegroundColor = color;
                Console.WriteLine($"{message, 10}... End");
                Console.ResetColor();
            }
        }
        static async Task<string> Task4(){
            Task<string> task4 = new Task<string>(
                () =>{
                    DoSomething(10, "T4", ConsoleColor.Green);
                    return "Return from T4";
                }
            );

            task4.Start();
            var kq = await task4;
            Console.WriteLine("T4 hoan thanh");
            return kq;

        }
        static async Task<string> Task5(){
            Task<string> task5 = new Task<string>(
                (object obj) =>{    
                    string t = (string)obj;
                    DoSomething(4, "T5", ConsoleColor.Red);
                    return $"Return from {t}";
                }, "T5");
            task5.Start();
           var kq = await task5;
           Console.WriteLine("T5 hoan thanh");
           return kq;
        }

        static async Task<Object> Abc(){
            Task<Object> task = new Task<object>(
                ()=>{
                    //....
                    return new object();
                }
            );
            task.Start();
            var kq = await task;
            return kq;
        }


        static async Task<string> GetWeb(string url){

            HttpClient httpClient = new HttpClient();
            Console.WriteLine("bat dau tai noi dung");
            HttpResponseMessage kq = await httpClient.GetAsync(url);
            Console.WriteLine("Bat dau doc noi dung");
            string content = await kq.Content.ReadAsStringAsync();
            Console.WriteLine("Hoan thanh");
            return content;

        }
        static async Task Main(string[] args)
        {

            // Task<string> task4 = new Task<string>(
            //     () =>{
            //         DoSomething(10, "T4", ConsoleColor.Green);
            //         return "Return from T4";
            //     }
            // );


            // Task<string> task5 = new Task<string>(
            //     (object obj) =>{    
            //         string t = (string)obj;
            //         DoSomething(4, "T5", ConsoleColor.Red);
            //         return $"Return from {t}";
            //     }, "T5");

            var task = GetWeb("https://www.facebook.com/");


            // Task<string> task4 = Task4();
            // Task<string> task5 = Task5();

            // task4.Start();
            // task5.Start();

            DoSomething(6, "T6", ConsoleColor.Magenta);
            var  content = await task;
            Console.WriteLine(content);

            // Task.WaitAll(task4, task5);

            // var kq4 = task4.Result;
            // var kq5 = task5.Result;

            // var kq4 = await task4;
            // var kq5 = await task5;

            // Console.WriteLine(kq4);
            // Console.WriteLine(kq5);

            Console.Write("Press any key: ");
            Console.ReadKey();
        }
    }
}
