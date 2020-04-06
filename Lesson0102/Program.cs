using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0102
{
    class Program
    {
        static void Main(string[] args)
        {
            // Các toán tử
            // Toán tử số học: +; -; *; /; %

            // Toán tử so sánh: >; >=; <; <=; ==; !=

            // Toán tử logic: && (and - và) ;  || (or - hoặc); !

            // Toán tử gán: =; +=; -=; *=; /=; %=

            // Toán tử tăng/ giảm: ++; --

            //  Toán tử nối chuỗi: +

            // Toán tử điều kiện: (Biểu thức điều kiện) ? <gt đúng> : <gt sai>;

            //example
            int x = 115, y = 255;
            int z;
            // Toán tử số học: +; -; *; /; %
            z = x + y;
            Console.WriteLine("{0} + {1} = {2}", x, y, z);

            z = x - y;
            Console.WriteLine("{0} - {1} = {2}", x, y, z);

            z = x * y;
            Console.WriteLine("{0} * {1} = {2}", x, y, z);

            z = x / y;
            Console.WriteLine("{0} / {1} = {2}", x, y, z);

            z = x % y;
            Console.WriteLine("{0} % {1} = {2}", x, y, z);

            //So sánh

            bool flag;
            flag = x > y;
            Console.WriteLine(flag);

            flag = x < y;
            Console.WriteLine(flag);

            flag = (x >= y) && (x < y);
            Console.WriteLine(flag);

            flag = (x >= y) || (x < y);
            Console.WriteLine(flag);

            flag = !(x >= y);
            Console.WriteLine(flag);

            // gán:
            x = 123;
            Console.WriteLine("x++ = {0} ", x++);

            Console.WriteLine("x++ = {0} ", x++);

            y = 12;
            Console.WriteLine("++y={0}", ++y);

            z = 123;
            z += 100; // z=z+100;

        }
    }
}
