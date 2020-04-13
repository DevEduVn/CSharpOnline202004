using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05._3.Array1Lab02
{
    class Program
    {
        /// <summary>
        ///  Tạo menu thực hiện các chức năng tương ứng
        ///  1. Nhập n, và mảng n số nguyên (n>0 và n<1000)
        ///  2. In danh sách các phần tử
        ///  3. In các phần từ là số nguyên tố, tính tổng
        ///  4. In ra các phần tử có giá trị bằng m và vị trí tương ứng (m nhập từ bàn phím)
        ///  5. Đếm xem có bao nhiêu phần tử là số chính phương.
        ///  6. Sắp xếp mảng (1=> tăng dần; 2=> giảm dần)
        ///  7. Thoát
        ///  
        /// Xây dựng đơn vị hàm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int n=0, ChucNang=0;
            do
            {
                Menu();
                Console.Write("Chon chuc nang:");
                ChucNang = int.Parse(Console.ReadLine());
                switch (ChucNang)
                {
                    case 1:
                        Input(out n, arr);
                        Console.ReadKey();
                        break;
                    case 2:
                        Output(n, arr);
                        Console.ReadKey();
                        break;
                    case 3:
                        OutputNT(n, arr);
                        Console.ReadKey();
                        break;
                    case 4:
                        Output4(n, arr);
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Goodbye!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Ban chon sai chuc nang.");
                        break;
                }

            } while (ChucNang!=7);

        }

        static void Menu()
        {
            Console.WriteLine("\n ============MENU==========");
            Console.WriteLine("\t1. Nhập n, và mảng n số nguyên (n>0 và n<1000) ");
            Console.WriteLine("\t2. In danh sách các phần tử ");
            Console.WriteLine("\t3. In các phần từ là số nguyên tố, tính tổng ");
            Console.WriteLine("\t4. In ra các phần tử có giá trị bằng m và vị trí tương ứng (m nhập từ bàn phím) ");
            Console.WriteLine("\t5. Đếm xem có bao nhiêu phần tử là số chính phương. ");
            Console.WriteLine("\t6. Sắp xếp mảng (1=> tăng dần; 2=> giảm dần ");
            Console.WriteLine("\t7. Thoát");
        }
        static void Input(out int n, int[] arr)
        {
            do
            {
                Console.Write("n=");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n >= 1000);
            Console.WriteLine("\n Nhap mang arr");
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}]=", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Output(int n,int[] arr)
        {
            Console.WriteLine("Danh sach:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,5}", arr[i]);
            }
        }

        //Hàm kiểm tra số nguyên tố
        static bool CheckNT(int num)
        {
            bool flag = true;
            if (num < 2) return false;
            for (int i = 2; i <=Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        //Hàm hiển thị danh sách số nguyên tố, tính tổng
        static void OutputNT(int n, int[] arr)
        {
            Console.WriteLine("\n Danh sach so nguyen to:");
            int TongNT = 0;
            for (int i = 0; i < n; i++)
            {
                if(CheckNT(arr[i]) == true)
                {
                    Console.Write("{0,5}", arr[i]);
                    TongNT += arr[i];
                }
            }
            if (TongNT > 0)
            {
                Console.WriteLine("\n Tong=" + TongNT);
            }
            else
            {
                Console.WriteLine("\n Khong co so nguyent to nao");
            }
        }

        // 4. hàm in các số thỏa mãn...
        static void Output4(int n, int[] arr)
        {
            int m;
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Vị trí");
            for (int i = 0; i < n; i++)
            {
                if(arr[i] == m)
                {
                    Console.Write("{0,4}", i);
                }
            }
        }


        /*
         Bài tập:
         1. Nhập số nguyên dương n
         => In ra ma trận hình xoáy ốc
         => ví dụ n=4

            1   2   3   4
            12  13  14  5
            11  16  15  6
            10  9   8   7

        2. Nhập số nguyên dương n và mảng n*n số nguyên
        => In ra dạng ma trận xoáy ốc
         */ 
    }
}
