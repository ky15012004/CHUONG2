using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_C2
{
    class Program
    {
        public static int TinhTong(int a_224, int b_224 = 10)
        {
            return a_224+b_224;
        }
        static void Main(string[] args)
        {
            int a_224;
            Console.WriteLine("Nhap a: ");
            a_224 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tong la: {TinhTong(a_224)}");
            Console.WriteLine($"Tong la: {TinhTong(a_224, 13)}");
            Console.ReadKey();
        }
    }
}
