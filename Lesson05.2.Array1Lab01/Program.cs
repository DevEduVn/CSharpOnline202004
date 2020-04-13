using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._2.Array1Lab01
{
    class Program
    {
        /// <summary>
        /// - Nhập vào số nguyên n, và mảng n số nguyên
        /// - In ra danh sách mảng số nguyên vừa nhập
        /// - Sắp xếp mảng số nguyên theo thứ tự tăng dần
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // 15'
            int n;
            Console.Write("Nhap n=");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            // Nhập giá trị cho từng phần tử trong mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            // In các phần tử
            Console.WriteLine("\n Danh sach cac phan tu trong mang:");
            foreach (var item in arr)
            {
                Console.Write("{0,5}", item);
            }

            //Sắp xếp
            // 12 23 32 24 44 =>
            // 12 
            // 12 23
            // 12 23 24 32 44
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n Danh sach cac phan tu trong mang (tang):");
            foreach (var item in arr)
            {
                Console.Write("{0,5}", item);
            }

            Console.ReadKey();
        }
    }
}
