using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._3.ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Foreach: Lặp trong một tập hợp, mảng
            string[] Names = { "Hung", "Dung", "Sang", "Trong", "Phuc", "Ngan", "Dam", "Binh minh" };
            Console.WriteLine("Danh sach bang vang ten:");
            foreach (var item in Names)
            {
                Console.WriteLine("Welcome to ," + item);
            }

            Console.ReadKey();
            Console.WriteLine("Danh sach bang vang ten:");
            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine("Welcome to ," + Names[i]);
            }

            Console.ReadKey();
        }
    }
}
