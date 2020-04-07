using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.Read_ReadLine
{
    /// <summary>
    ///     Mô tả lệnh Read, ReadLine
    /// </summary>
    class Program
    {
        /// <summary>
        ///     Read | ReadLine
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Console.Read() => Nhận một ký tự từ bàn phím
            //int x;
            //Console.Write("Nhan mot ky tu:");
            //x = Console.Read();
            //Console.WriteLine("x=" + x);


            // Console.ReadLine() => Nhận một chuỗi ký tự
            Console.Write("Moi ban nhap ten:");
            //var Name = Console.ReadLine();
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Welcome to, " + Name);

            int x, y;
            Console.Write("Input x=");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input y=");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} ; {1}", x, y);
            Console.ReadKey();
        }
    }
}
