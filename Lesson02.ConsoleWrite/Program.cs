using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.ConsoleWrite
{
    /// <summary>
    /// Demo các câu lệnh xuất nội dung ra màn hình.
    /// Console.Write
    /// Console.WriteLine
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Lớp Console
            // Console.Write=>  Xuất nội dung ra màn hình,
            //                  Con trỏ ở cuối dòng
            Console.Write("Xin chao cac ban CSharpOnline");
            Console.Write("-- Viết tiếp.");

            //Console.WriteLine => Viết xong 1 dòng, con trỏ trên dòng mới
            Console.WriteLine("\n Welcome to, Devmaster Academy!");
            Console.WriteLine("Hello, Chung Trinhj");

            // Xác định vị trí hiển thị, và một số đặc tả
            int x = 10, y = 25;
            int z = x + y;

            Console.WriteLine("{0} + {1} = {2} ", x, y, z); // 10 +25=35
            Console.WriteLine("{2} ~ {1} + {0}", x, y, z); // 35 ~ 25 + 10;

            Console.WriteLine("\n\t {0} + {1} = {2}", x, y, z);

            var Name = "Chung Trinhj";
            int Age = 40;
            float Salary = 1234567.89f;
            Console.WriteLine("\t Infor:");
            Console.WriteLine("{0}{1}{2}", Name, Age, Salary);

            Console.WriteLine("{0,20}{1,5}{2,20}", Name, Age, Salary);
            Console.WriteLine("{0,-20}{1,5} {2:C2}", Name, Age, Salary);


            Console.ReadKey();

        }
    }
}
