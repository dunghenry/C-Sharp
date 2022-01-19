using System.Reflection.PortableExecutable;
using System.IO;
using System;

namespace CS28File
{
    //DriveInfo
    //Directory - Thu muc
    //File
    class Program
    {
        static void ListFileDirectory(string path)
        {
            String[] directories = System.IO.Directory.GetDirectories(path);
            String[] files = System.IO.Directory.GetFiles(path);
            
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
                ListFileDirectory(directory); // Đệ quy
            }
        }
        static void Main(string[] args)
        {
            DriveInfo drive = new DriveInfo(@"E:\");
            Console.WriteLine($"Drive: {drive.Name}");
            Console.WriteLine($"Drive Type: {drive.DriveType}");
            Console.WriteLine($"Label: {drive.VolumeLabel}");
            Console.WriteLine($"Format: {drive.DriveFormat}");
            Console.WriteLine($"Size: {drive.TotalSize}");
            Console.WriteLine($"Free: {drive.TotalFreeSpace}");


            var drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"Drive: {item.Name}");
                Console.WriteLine($"Drive Type: {item.DriveType}");
                Console.WriteLine($"Label: {item.VolumeLabel}");
                Console.WriteLine($"Format: {item.DriveFormat}");
                Console.WriteLine($"Size: {item.TotalSize}");
                Console.WriteLine($"Free: {item.TotalFreeSpace}");
            }

            string path = @"E:\";

            string path1 = "Abc";

            Directory.CreateDirectory(path1); //Tao thu muc

            Directory.Delete(path1); //Xóa thu muc

            //Kiem tra su ton tai cua thu muc
            if(Directory.Exists(path)){
                Console.WriteLine($"{path} - ton tai");
            }
            else{
                Console.WriteLine($"{path} - khong ton tai");
            }

            Console.WriteLine("-------------------------");

            if(Directory.Exists(path1)){
                Console.WriteLine($"{path1} - ton tai");
            }
            else{
                Console.WriteLine($"{path1} - khong ton tai");
            }

            string path2 = "obj";
            var files = Directory.GetFiles(path2);
            var directories = Directory.GetDirectories(path2);
            foreach(var directory in directories){
                Console.WriteLine($"{directory}");
            }
            Console.WriteLine();
            foreach(var file in files){
                Console.WriteLine($"{file}");
            }
            
            ListFileDirectory(path2);

            Console.WriteLine(Path.DirectorySeparatorChar); // \

            var path3 = Path.Combine("Cha", "Con", "Chau.txt"); // Cha\Con\Chau.txt
            path3 = Path.ChangeExtension(path3, "md"); //Đổi tên .đuôi của file
            Console.WriteLine(path3);
            Console.WriteLine(Path.GetDirectoryName(path3)); // Cha\Con
            Console.WriteLine(Path.GetExtension(path3)); // .md
            Console.WriteLine(Path.GetFileName(path3)); // Chau.md
            Console.WriteLine(Path.GetFullPath(path3)); // E:\CSharp-tutorial\CS28.File\Cha\Con\Chau.md

            //! File
            //? Khi file đã có sẵn mà chúng ta lại thêm nội dung thì nó sẽ xóa hoàn toàn nội dung cũ và thay vào đó là nội dung mới
            
            string filename = "abc.txt";
            string content = "Xin chao tat ca cac ban hehe sss";
            File.WriteAllText(filename, content);
            File.AppendAllText(filename, content); // Nối thêm chuỗi mới vào tệp 

            string nd = File.ReadAllText(filename); // Đọc 
            Console.WriteLine(nd);

            //File.Move("abc.txt", "123.txt"); //Đổi tên file
            //File.Copy("abc.txt", "filemoi.txt"); // Copy file
            // File.Delete("abc.txt"); // Delete file
        }
    }
}
