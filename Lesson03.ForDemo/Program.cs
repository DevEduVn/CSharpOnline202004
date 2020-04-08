using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03.ForDemo
{
    class Program
    {
        /// <summary>
        /// Cấu trúc lặp For
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i = 1;
            //Dạng 1: for đầy đủ
            for ( i=1; i<=10; i++)
            {
                Console.WriteLine("\t" + i);
            }
            Console.ReadKey();
            // Tính tổng các số nguyên từ 1 => n;
            int n;
            Console.Write("Nhap n=");
            n = int.Parse(Console.ReadLine());
            int Tong = 0;
            for ( i = 1; i <=n; i++)
            {
                Tong += i;
            }
            Console.WriteLine("Tong=" + Tong);
            Console.ReadKey();
            //Dạng 2: for khuyết thành phần
            Console.WriteLine("==================For khuyet");
            i = 1;
            for( ;i<=10; i++)
            {
                Console.Write("{0,4}", i);
            }
            Console.ReadKey();
            Console.WriteLine("\n==================For khuyet");
            i = 1;
            for ( ; ;i++)
            {
                Console.Write("{0,4}", i);
                if (i == 10) break; // Nếu không dòng này thì biên dịch lỗi
            }

            Console.ReadKey();
            Console.WriteLine("\n==================For khuyet");
            i = 1;
            for ( ;i<=10;)
            {
                Console.Write("{0}", i++);
                //i = (i == 1) ? 0 : 1; 
            }
            Console.WriteLine("\n================== For khuyet toan bo");
            Console.ReadKey();
            //Dạng 3: for khuyết toàn bộ
            /*
            byte j = 1;
            for (; ;)
            {
                Console.Write("{0, 5}", j++); // not over
                //if (j == 255) Console.ReadLine();
                // => vòng lặp vô hạn
            }
            */
            
            Console.ReadKey();
            Console.WriteLine("\n==================For không thân\n");
            //Dạng 4: for không thân
            Tong = 0;
            int x = 1;
            for (x = 1,Tong=0; x <= 10; Console.Write("{0,4}",x), Tong += x, x++);
            Console.WriteLine("\n Tong=" + Tong);
            Console.ReadKey();

        }
    }
}
