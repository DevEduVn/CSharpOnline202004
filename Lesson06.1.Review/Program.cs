using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06._1.Review
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cấu trúc điều khiển ; Mảng
            // mảng: mảng 1 chiều, nhiều chiều, mảng zic zắc
            // Cấu trúc điều khiển: 
            // - if, switch
            // - for, do..while, while, foreach
            // - break; continue; goto; return;...
            string[] Names = {"Chung","Trinh","Van","Donal Trump" };

            Console.WriteLine("Name list:");
            foreach (var item in Names)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
