using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0101
{
    class Program
    {
        static void Main(string[] args)
        {
            // Biến, kiểu dữ liệu, khai báo...
            //Cú pháp:
            /*
                Kieu_du_lieu  Ten_bien;
                Kieu_du_lieu  Ten_Bien = Gia_Trị [,..] ;

                Kiểu dữ liệu động
                var ten_bien=giatri;

             */
            //Khai báo biến kiểu số nguyên
            int x, y, z;
            float a = 12.5f, b = 13.5f;
            string Dia_Chi = "25 Vũ Ngọc Phan";
            // Gán giá trị
            x = 5;
            y = 15;
            z = x + y;

            // In ra trị
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(Dia_Chi);

            Console.WriteLine("{0} + {1} = {2}", x, y, z);

            Console.ReadKey();

            /*
             *  HẰNG
              - Giá trị không đổi trong suốt quá trình tính toán
              - Cú pháp:
              const Kieu_du_lieu Ten_hang = Gia_tri;

             */
            const double PI = 3.1415;

            Console.WriteLine(PI);
            Console.ReadKey();
        }
    }
}
