using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_C2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Students_224 = new List<string>();
            Console.WriteLine("Nhap n:");
            int n_224 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n_224; i++)
            {
                Console.WriteLine($"Nhap ten sinh vien thu {i}");
                string s = Console.ReadLine();
                Students_224.Add(s);
            }

            Console.WriteLine("Danh sach ten hoc sinh: ");
            foreach(var student_224 in Students_224)
            {
                Console.WriteLine(student_224);
            }

            Console.ReadKey();
        }
    }
}
