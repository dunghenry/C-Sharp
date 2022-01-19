using System;
using System.Collections.Generic;
namespace CS27.Queue_Stack_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cachoso = new Queue<string>();

            cachoso.Enqueue("Ho so 1");
            cachoso.Enqueue("Ho so 2");
            cachoso.Enqueue("Ho so 3");
            cachoso.Enqueue("Ho so 4");

                foreach (var hs in cachoso)
                {
                    Console.WriteLine(hs);
                }

            var hoso = cachoso.Dequeue(); //Loại bỏ phần tử đầu tiên
            Console.WriteLine($"Xu ly ho so {hoso} - {cachoso.Count}");

            //? Stack vào sau ra trước

            Stack<string> hanghoa = new Stack<string>();
            hanghoa.Push("mat hang 1");
            hanghoa.Push("mat hang 2");
            hanghoa.Push("mat hang 3");
            hanghoa.Push("mat hang 4");
            Console.WriteLine(hanghoa.Count); // 4

            var mathang = hanghoa.Pop(); // Loai bo phan tu cuoi cung them vao
            Console.WriteLine($"Boc do {mathang}");

            LinkedList<string> cacbaihoc = new LinkedList<string>();
            var bh1 = cacbaihoc.AddFirst("Bai hoc 1");
            var bh3 = cacbaihoc.AddLast("Bai hoc 3");
            // var bh2 = cacbaihoc.AddAfter(bh1, "Bai hoc 2");
            LinkedListNode<string> bh2 = cacbaihoc.AddAfter(bh1, "Bai hoc 2"); //Them bh 2 vao sau bh1
            cacbaihoc.AddLast("Bai hoc 4");
            cacbaihoc.AddLast("Bai hoc 5");
            
            foreach (var bh in cacbaihoc)
            {
                Console.WriteLine(bh);
            }
            Console.WriteLine("--------------------");
            var node = bh2;
            Console.WriteLine(node.Value);
            node = node.Next; //Bài học sau bh2
            Console.WriteLine(node.Value);

            //Previous tương tự Next
            Console.WriteLine("--------------------");
            var node1 = bh3;
            Console.WriteLine(node1.Value);
            node1 = node1.Previous; //Bài học trước bh2
            Console.WriteLine(node1.Value);
            
            Console.WriteLine("--------------------");
            var nodeLast = cacbaihoc.Last;
            while (nodeLast != null){
                Console.WriteLine(nodeLast.Value);
                nodeLast = nodeLast.Previous;
            }


            //!
            Dictionary<string, int> sodem = new Dictionary<string, int>(){
                ["one"] = 1,
                ["two"] = 2
            };
            sodem["three"] = 3;
            sodem.Add("four", 4);

            // foreach (KeyValuePair<string, int> item in sodem){
            //     Console.WriteLine($"{item.Key} - {item.Value}");
            // }

            var keys = sodem.Keys;
            var values = sodem.Values;
            foreach (var k in keys)
            {
                Console.WriteLine(k); //key
                Console.WriteLine(sodem[k]); //sodem[key] = sodem["one",....]
            }

            //!
            Console.WriteLine("--------------------");
            HashSet<int> set1 = new HashSet<int>(){1, 2, 3, 4};
            HashSet<int> set2 = new HashSet<int>(){2, 7, 1, 9};
            set1.Add(5);
            set1.Remove(9);
            
            foreach (var item in set1)
            {
                Console.Write(item + " ");
            }

            set1.UnionWith(set2); // Gộp các phần tử của set 2 vào set 1
            Console.WriteLine();
            foreach (var item in set1)
            {
                Console.Write(item + " ");
            }
            
            //Giao của 2 tập hợp

            set1.IntersectWith(set2); // Lấy ra các phần tử có ở hai tập
            Console.WriteLine();
            foreach (var item in set1)
            {
                Console.Write(item + " ");
            }

        }
    }
}
