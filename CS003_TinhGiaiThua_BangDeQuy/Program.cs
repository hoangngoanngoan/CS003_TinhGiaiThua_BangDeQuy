using System;
using System.ComponentModel.Design;
namespace CS003_TinhGiaiThua_BangDeQuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.WriteLine("Chương trình tính giai thừa bằng đệ quy");
            int a;
            Console.Write("Nhấp số: "); a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Kết quả của chương trình là: {TinhGT(a)}");
        }
        static int TinhGT(int a)
        {
            int ketqua;
            ketqua = a;
            if (a == 0) return ketqua = 1;
            else ketqua *= TinhGT(a - 1);
            return ketqua;
        }
    }
}