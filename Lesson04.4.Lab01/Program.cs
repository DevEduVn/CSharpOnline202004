using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._4.Lab01
{
    class Program
    {
        //Lab02.4: Viết chương trình in ra các số tổng 3 ký tự số là chẵn từ 100-999; 123
        //Lab03.4.1: Viết chương trình in ra dãy amstrong có 3 chữ số: 153 = 1^3 + 5^3 + 3^3;
        static void Main(string[] args)
        {
            //15'
            Console.WriteLine("Lab02.4: Viết chương trình in ra các số tổng 3 ký tự số là chẵn từ 100-999; 123");
            for (int i = 100; i <= 999; i++)
            {
                int t = i / 100;
                int c = (i / 10) % 10; // 123/10 =12; 12%10 =2
                int v = i % 10; // 123 %10 =3; 
                if ((t + c + v) % 2 == 0)
                    Console.Write("{0,5}", i);
            }

            Console.WriteLine("\n Lab03.4.1: Viết chương trình in ra dãy amstrong có 3 chữ số: 153 = 1^3 + 5^3 + 3^3;");
            for (int i = 100; i <= 999; i++)
            {
                int t = i / 100;
                int c = (i / 10) % 10; // 123/10 =12; 12%10 =2
                int v = i % 10; // 123 %10 =3; 
                if(t*t*t + c*c*c +v*v*v == i)
                {
                    Console.Write("{0,5}", i);
                }
            }
                Console.ReadLine();
        }
    }
}
