using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._2.While
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập n, in ra các <=n
            int n;
            do
            {
                Console.Write("Nhap n=");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n >= 999999);

            Console.WriteLine("N={0}", n);

            // Dùng vòng lặp while để in ra các số nguyên <=n
            int i = 1;
            while (i <= n)
            {
                Console.Write("{0,4}", i++);
            }
            Console.WriteLine();
            i = n;
            short t = 10;
            while (i > 0)
            {
                Console.Write("{0,4}", i--);
                t *= (short)i;
                Console.Write("T{0,6}", t);
            }
            Console.ReadLine();

        }
    }
}
