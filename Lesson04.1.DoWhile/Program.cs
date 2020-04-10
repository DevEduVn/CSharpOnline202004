using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._1.DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Nhập vào biến số nguyên n (n>0, n<10000)
            int n;
            do
            {
                Console.Write("Nhap n=");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n >= 10000);

            Console.WriteLine("N={0}", n);

            // In ra các số nguyên trong khoảng [1-n]
            // Tính tổng;
            int Tong = 0;
            int i = 1;
            do
            {
                Console.Write("{0,4}", i);
                Tong += i;
                i++;
            } while (i < n);
            Console.WriteLine("Tong = " + Tong);

            Console.ReadKey();
            Console.WriteLine();
            i = 1;
            Tong = 0;
            do
            {
                if(i<n-1)
                    Console.Write(i + " + ");
                else
                    Console.Write(i + " = ");

                Tong += i;
                i++;
            } while (i < n);
            Console.WriteLine(Tong);
            Console.ReadKey();

            //BT: In ra các số chính phương <=n và tính tổng các số chính phương đó
            //10'
            // 4, 9, 16 

            i = 1;
            Tong = 0;
            do
            {
                //Giả định số i không phải là số chính phương
                bool flag = false;
                int j = 2;
                do
                {
                    if (j * j == i)
                    {
                        flag = true;
                        break;
                    }
                    j++;
                } while (j <= Math.Sqrt(i));

                if (flag == true)
                {
                    Console.Write("{0,4}", i);
                    Tong += i;
                }

                i++;
            } while (i <= n);
            Console.WriteLine("Tong chinh phuong =" + Tong);
            Console.ReadLine();
        }
    }
}
