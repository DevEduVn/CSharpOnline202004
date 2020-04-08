using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.IfLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Giải phương trình bậc nhất: ax+b=0
            // nhập các hệ số
            //10'.
            // Khai báo biến hệ số, biến nghiệm
            float a, b, x;
            //Input
            Console.Write("Nhap he so a=");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap he so b=");
            b = float.Parse(Console.ReadLine());

            // 1=> a==0 
            // 2=> a !=0 => 
            // xử lý
            if (a == 0) // 0.x + b ==0
            {
                if (b == 0) // 0.x + 0 = 0
                {
                    Console.WriteLine("Phuong trình vo so nghiem");
                }
                else  // 0.x + b =0 
                {
                    Console.WriteLine("Phuong trình  so nghiem");
                }
            }
            else // a !=0 => a.x + b =0;
            {
                x = -b / a;
                Console.WriteLine("Nghiem phuong trinh x={0}", x);
            }

            Console.ReadLine();
        }
    }
}
