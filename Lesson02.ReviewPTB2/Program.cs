using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.ReviewPTB2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. BTVN: giải phương trình bậc 2
            // ax2 + bx + c =0
            float a, b, c, x1, x2;

            // Nhập các hệ số
            Console.Write("Nhap he so a=");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap he so b=");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhap he so c=");
            c = float.Parse(Console.ReadLine());
            //
            if(a != 0) // pt bậc 2
            {
                // Tính delta
                float delta = b * b - 4 * a * c;
                if(delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }else if(delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    Console.WriteLine("Nghiem kep x1=x2={0}", x1);
                }
                else // delta>0
                {
                    x1 = (-b - (float) Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Nghiem phuong trinh \n x1={0} \n x2={1}", x1, x2);
                }
            }
            else // giải phương trình bậc nhất
            {
                if(b != 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem x={0}", -c / b);
                }
                else //b==0
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
            }
            //
            Console.ReadKey();

            float max;
            max = (a > b) ? a : b;
            Console.WriteLine("{0} > {1} ? {2}:{3} = {4}", a, b, a, b, max);

            Console.ReadKey();
        }
    }
}
