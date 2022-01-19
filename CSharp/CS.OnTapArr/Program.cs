using System;
namespace CS.OnTapArr
{
    class Program
    {
        //Input
        static void Input(int[] a, int n){
            for (int i = 0; i < n; i++){
                Console.Write("Nhap phan tu thu " + i + " : ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        //Output
        static void Output(int[] a, ref int n){
            Console.Write("Xuat mang : " + "\t");
            for(int i = 0; i < n; i++){
                Console.Write(a[i] + "\t");
            }
        }
        static int Max(int[] a, int n){
            int max = a[0];
            for(int i = 1; i < n; i++){
                if(a[i] > max)
                    max = a[i];
            }
            return max;
        }
        static int Min(int[] a, int n){
            int min = a[0];
            for(int i = 1; i < n; i++){
                if(a[i] < min)
                    min = a[i];
            }
            return min;
        }
        static float TBC(int[] a, int n){
            int count = 0;
            int sum = 0;
            for(int i = 0; i < n; i++){
                sum += a[i];
                count++;
            }
            return (float) sum / count;
        }
        static void Xoa(int[] a, ref int n, int vt){
            if(vt < 0){
                vt = 0;
            }
            else if(vt >= n){
                vt = n - 1;
            }
            for(int i = vt; i < n - 1; i++){
                a[i] = a[i+1];
            }
            n--;
        }
        static void Chen(int[] a, ref int n, int vt, int value){
            if(vt < 0){
                vt = 0;
            }
            else if(vt >= n){
                vt = n - 1;
            }
            for(int i = n; i > vt; i--){
                a[i] = a[i - 1];
            }
            a[vt] = value;
            n++;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Input(a, n);
            Console.WriteLine();
            Console.WriteLine("Gia tri lon nhat cua mang la: " + Max(a, n));
            Console.WriteLine();
            Console.WriteLine("Gia tri nho nhat cua mang la: " + Min(a, n));
            Console.WriteLine();
            Console.WriteLine("Trung binh cong cac phan tu cua mang la: " + TBC(a, n));
            Console.Write("Nhap vi tri phan tu muon xoa: ");
            int vt = int.Parse(Console.ReadLine());
            Xoa(a, ref n, vt);
            Output(a, ref n);
            Console.Write("\nNhap vi tri muon chen: ");
            int vt1 = int.Parse(Console.ReadLine());
            Console.Write("\nNhap gia tri can chen: ");
            int value = int.Parse(Console.ReadLine());
            Chen(a, ref n, vt1, value);
            Output(a, ref n);

        }
    }
}
