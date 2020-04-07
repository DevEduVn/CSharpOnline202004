using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.IfDemo
{
    class Program
    {
        /// <summary>
        /// Mô tả cấu trúc if
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            int x, y;
            Console.Write("x=");
            x = int.Parse(Console.ReadLine());
            // if đơn
            if(x % 2 == 0)
            {
                Console.WriteLine("{0} la so chan", x);
            }
            // if đầy đủ (if...else)
            // Kiểm tra giá trị của x là chẵn hay lẻ
            if (x % 2 == 0)
            {
                Console.WriteLine("{0} la so chan", x);
            }
            else
            {
                Console.WriteLine("{0} la so le", x);
            }
            // if bậc thang (if...else if....)
            // Kiểm tra xem giá trị của x là:
            // >0 , âm hay = 0
            if (x < 0)
            {
                Console.WriteLine("{0} la so âm", x);
            }
            else if (x == 0)
            {
                Console.WriteLine("{0} =0", x);
            }
            else
            {
                Console.WriteLine("{0} la so duong", x);
            }
            // if lồng nhau
            // a = điểm toán, b =điểm văn; c= điểm trung bình
            // xếp loại

            float a, b, c;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            c = (a + b) / 2;
            if(c>=0 && c <= 10)
            {
                if (c < 5)
                    Console.WriteLine("Yeu");
                else if (c < 7)
                    Console.WriteLine("TB Kha");
                else if (c < 8)
                    Console.WriteLine("Kha");
                else if (c < 9)
                    Console.WriteLine("Gioi");
                else
                    Console.WriteLine("Xuat sac");
            }
            else // c<0 || c>10
            {
                Console.WriteLine("Ban nhap sai...");
            }
            Console.ReadLine();
        }
    }
}
