using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CS33.Dependency_P2
{
    class Horn
    {
        int level = 0;
        public Horn(int _level) => this.level = _level;
        public void Beep() => Console.WriteLine("Beep...Beep...Beep...");
    }
    class Car
    {
        Horn horn { set; get; }
        public void Beep()
        {
            // Horn horn = new Horn();
            horn.Beep();

        }
        public Car(Horn _horn) => this.horn = _horn;
    }
    interface IClassC
    {
        public void ActionC();
    }
    interface IClassB
    {
        public void ActionB();
    }
    class ClassC : IClassC
    {
        public void ActionC() => Console.WriteLine("Action in ClassC");
    }

    class ClassB : IClassB
    {
        // Phụ thuộc của ClassB là ClassC
        IClassC c_dependency;

        public ClassB(IClassC classc) => c_dependency = classc;
        public void ActionB()
        {
            Console.WriteLine("Action in ClassB");
            c_dependency.ActionC();
        }
    }

    class ClassA
    {
        // Phụ thuộc của ClassA là ClassB
        IClassB b_dependency;

        public ClassA(IClassB classb) => b_dependency = classb;
        public void ActionA()
        {
            Console.WriteLine("Action in ClassA");
            b_dependency.ActionB();
        }
    }
    class ClassB2 : IClassB
    {
        IClassC c_dependency;
        string message;
        public ClassB2(IClassC classc, string mgs)
        {
            c_dependency = classc;
            message = mgs;
            Console.WriteLine("ClassB2 is created");
        }
        public void ActionB()
        {
            Console.WriteLine(message);
            c_dependency.ActionC();
        }
    }

    public class MyServiceOptions{
        public string data1{set; get;}
        public int data2{set; get;}
    }

    public class MyService{
        public string data1{set; get;}
        public int data2{set; get;}
        public MyService(IOptions<MyServiceOptions> options){
            var _options = options.Value;
            data1 = _options.data1;
            data2 = _options.data2;
        }
        public void PrintData() => Console.WriteLine($"{data1} / {data2}");
    }
    // interface IClassC
    // {
    //     public void ActionC();
    // }
    // class ClassC : IClassC
    // {
    //     public void ActionC() => Console.WriteLine("Action in ClassC");
    // }

    class Program
    {
        public static IClassB CreateB2(IServiceProvider provider){
            var b2 = new ClassB2(
                        provider.GetService<ClassC>(), "Thuc hien trong ClassB2"
                    );
                    return b2;
        }
        static void Main(string[] args)
        {
            // Horn horn = new Horn(7);
            // Car oto = new Car(horn);
            // oto.Beep();

            var services = new ServiceCollection();

            // services.AddSingleton<IClassC, ClassC>();
            // services.AddTransient<IClassC, ClassC>();
            // services.AddScoped<IClassC, ClassC>();

            //Đăng kí
            // var provider = services.BuildServiceProvider();

            // var a = provider.GetService<IClassC>();
            // for (int i = 0; i < 5; i++)
            // {
            //     IClassC c = provider.GetService<IClassC>();
            //     Console.WriteLine(c.GetHashCode());
            // }

            // Console.WriteLine(a.GetHashCode());

            // using(var scope = provider.CreateScope()){
            //     var provider1 = scope.ServiceProvider;
            // for (int i = 0; i < 5; i++)
            // {
            //     IClassC c = provider1.GetService<IClassC>();
            //     Console.WriteLine(c.GetHashCode());
            // }
            // }


            // services.AddSingleton<ClassA, ClassA>();
            // services.AddSingleton<IClassB>(CreateB2);
            // services.AddSingleton<IClassC, ClassC>();

            // var provider = services.BuildServiceProvider();
            // ClassA a = provider.GetService<ClassA>();
            // a.ActionA();
            //! Cách 1
            services.AddSingleton<MyService>();
            services.Configure<MyServiceOptions>(
                (MyServiceOptions options) =>{
                    options.data1 = "Xin chao cac ban!";
                    options.data2 = 5;
                }
            );
            var provider = services.BuildServiceProvider();
            var myservice = provider.GetService<MyService>();
            myservice.PrintData();

            IConfigurationRoot configurationRoot;
            // ConfigurationRoot configurationRoot;
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory());
            configurationBuilder.AddJsonFile("cauhinh.json");
            // configurationRoot = (ConfigurationRoot)configurationBuilder.Build();
            configurationRoot = configurationBuilder.Build();
            var sectionMyServiceOptions = configurationRoot.GetSection("MyServiceOptions");
            services.Configure<MyServiceOptions>(sectionMyServiceOptions);
            var data1 = configurationRoot.GetSection("MyServiceOptions").GetSection("data1").Value;
            Console.WriteLine(data1);

            var data2 = configurationRoot.GetSection("MyServiceOptions").GetSection("data2").Value;
            Console.WriteLine(data2);

            //? Cách 2
             var services1 = new ServiceCollection();

            IConfigurationRoot configurationRoot1;
            // ConfigurationRoot configurationRoot;
            ConfigurationBuilder configurationBuilder1 = new ConfigurationBuilder();
            configurationBuilder1.SetBasePath(Directory.GetCurrentDirectory());
            configurationBuilder1.AddJsonFile("cauhinh.json");
            // configurationRoot = (ConfigurationRoot)configurationBuilder.Build();
            configurationRoot1 = configurationBuilder1.Build();
            services1.AddSingleton<MyService>();
            var sectionMyServiceOptions1 = configurationRoot1.GetSection("MyServiceOptions");
            services1.Configure<MyServiceOptions>(sectionMyServiceOptions1);
            var provider1 = services1.BuildServiceProvider();
            var myservice1 = provider1.GetService<MyService>();
            myservice1.PrintData();
            
        }
    }
}
