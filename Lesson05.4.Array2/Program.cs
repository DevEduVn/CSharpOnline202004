using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._4.Array2
{
    class Program
    {
        /// <summary>
        /// Demo mảng 2 chiều
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[,] arr =
            {
                {10, 20, 30 },
                {15, 25, 35 },
                {10, 23, 35 }
            };
            int[,] a = new int[10,5];

            // xuất mảng
            Console.WriteLine("Mang phan tu:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,5}", arr[i, j]);
                }
                Console.WriteLine("\n");
            }

            // Tính tổng chéo chính (i==j) (Mảng vuông)
            int TongCC = 0;
            int n = arr.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        TongCC += arr[i, j];
                    }
                }
            }
            Console.WriteLine("Tổng chéo chính:" + TongCC);
            // Chéo phu: i=n-j (Mảng vuông)
            int TongCP = 0;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == n-j-1)
                    {
                        TongCP += arr[i, j];
                    }
                }
            }
            Console.WriteLine("Tổng chéo phụ:" + TongCP);
            Console.ReadLine();
        }
    }
}
