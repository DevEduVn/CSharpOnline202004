using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03.SwitchDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch
            int thu;
            Console.Write("Nhap thu = ");
            thu = int.Parse(Console.ReadLine());
            switch (thu)
            {
                case 1:
                    Console.WriteLine("Chu nhat");
                    break;
                case 2:
                    Console.WriteLine("Thu hai");
                    break;
                case 3:
                    Console.WriteLine("Thu ba");
                    break;
                case 4:
                    Console.WriteLine("Thu tu");
                    break;
                case 5:
                    Console.WriteLine("Thu nam");
                    break;
                case 6:
                    Console.WriteLine("Thu sau");
                    break;
                case 7:
                    Console.WriteLine("Thu bay");
                    break;
                default:
                    Console.WriteLine("Ban nhap sai");
                    break;
            }
            Console.ReadKey();
        }
    }
}
