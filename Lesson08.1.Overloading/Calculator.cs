using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08._1.Overloading
{
    /// <summary>
    ///  Lớp calculator: => Thực hiện các phép tính toán 
    ///     => tùy thuộc vào giá trị của tham số ứng với mỗi phương thức
    ///     
    /// </summary>
    class Calculator
    {
        // Sum
        public int Sum(int a)
        {
            int Tong = 0;
            for (int i = 0; i < a; i++)
            {
                Tong += i;
            }
            return Tong;
        }
        public int Sum(int a, int b)
        {
            int Tong = 0;
            for (int i = a; i < b; i++)
            {
                Tong += i;
            }
            return Tong;
        }
        public int Sum(int[] a)
        {
            int Tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Tong += a[i];
            }
            return Tong;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
        public float Add(float a, float b)
        {
            return a + b;
        }
        public float Add(float a, float b, float c)
        {
            return a + b + c;
        }

    }
}
