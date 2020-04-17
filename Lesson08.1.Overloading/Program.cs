using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08._1.Overloading
{
    /// <summary>
    ///  Overloading method:
    ///     - Một lớp có nhiều phương thức trung tên
    ///         -> Khác nhau về số lượng tham số
    ///         ->(Cùng số lượng tham số) -> Kiểu dữ liệu của các tham số
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Khoi tao doi tuong
            Calculator calc = new Calculator();
            int res = calc.Sum(10);
            Console.WriteLine("Tong=" + res);
            res = calc.Sum(10, 20);
            Console.WriteLine("Tong=" + res);

            int[] a = { 1, 3, 5, 7, 8, 9, 10 };
            res = calc.Sum(a);
            Console.WriteLine("Tong=" + res);

            Console.WriteLine("Tong - Add (int,int)" + calc.Add(10, 20));
            Console.WriteLine("Tong - Add (float,float)" + calc.Add(10.5F, 20F));
            Console.WriteLine("Tong - Add (float,float, float)" + calc.Add(10.5F, 20F, 30.5F));

            Console.ReadLine();
        }
    }
}
