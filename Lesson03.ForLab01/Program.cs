using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03.ForLab01
{
    class Program
    {
        /// <summary>
        /// Sử dụng vòng lặp for thực hiện yêu cầu:
        /// - Nhập vào biến số nguyên n (n>0, n<10000)
        /// - In ra các số nguyên tố <=n
        /// - Tính tổng các số nguyên tố  <=n;
        /// 15'
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n, Tong = 0;
            Console.Write("Nhap n=");
            n = int.Parse(Console.ReadLine());

            for (int i = 2;  i<=n; i++)
            {
                // Giả định số i là số nguyên tố
                bool flag = true;
                // Kiểm tra số i có phải là số nguyên tố thật không
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                    }
                }

                if (flag == true)
                {
                    Console.Write("{0,4} ", i);
                    Tong += i;
                }
            }

            Console.WriteLine("\n Tong =" + Tong);
            Console.ReadLine();
        }
    }
}
