using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03.SwitchDemo2
{
    class Program
    {
        /// <summary>
        /// Nhập vào biến tháng, biến năm => In ra số ngày 
        /// thang=4; nam =2020 => 
        /// Thang 4 nam 2020 có 30 ngày
        /// => 10'
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int Thang, Nam, SoNgay = 0;
            // Nhập tháng, nhập năm
            Console.Write("Thang=");
            Thang = int.Parse(Console.ReadLine());
            Console.Write("Nam=");
            Nam = int.Parse(Console.ReadLine());

            //Sử dụng cấu trúc switch
            // Nam % 4 ==0
            switch (Thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    SoNgay = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    SoNgay = 30;
                    break;
                case 2:
                    if ((Nam % 4 == 0 && Nam % 100 != 0) || Nam % 400 == 0)
                        SoNgay = 29;
                    else
                        SoNgay = 28;
                    break;
                default:
                    Console.WriteLine("Ban nhap sai");
                    break;
            }
            if (SoNgay > 0)
            {
                Console.WriteLine("Thang {0} nam {1} co {2} ngay!", Thang, Nam, SoNgay);
            }

            Console.ReadKey();
        }
    }
}
