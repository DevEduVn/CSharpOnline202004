using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05.Array01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Làm việc với mảng 1 chiều trong C#
            // Khai báo;
            // type[] <array_name>;
            // type[] <array_name> = new type[<size>];
            // type[] <array_name> = new type[]{<value1>,<value2>,...};
            // type[] <array_name> = {<value1>,<value2>,...};

            // ex1: Khai báo mảng số nguyên
            int[] arr1;
            // Khai báo và khởi tạo kích thước mảng
            int[] arr2 = new int[10]; // Mảng chưa 10 phần tử, chỉ số : 0->9
            float[] arr3 = new float[] { 10.1f, 20.2f, 30.3f };// Khai báo vào khởi tạo giá trị
            string[] names = {"Hung","Dung","Sang","Trong" }; // chỉ sổ: 0->3

            //=> Truy xuất (Gán giá trị, lấy giá trị) => Thông qua <array_name>[<index>];
            arr1 = new int[10];
            //=> Gán giá trị / duyệt mảng 
            // gán các số nguyên từ 1-> 10 vào mảng arr1
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = i;
            }
            //=> In giá trị các phần tử trong mảng
            Console.WriteLine("Danh sách:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("{0,4}", arr1[i]);
            }

            Console.WriteLine("\n Giá trị mảng arr3:");
            int index = 0;
            do
            {
                Console.Write("{0,5}", arr3[index]);
                index++;
            } while (index < arr3.Length);

            //In danh sách mảng names
            Console.WriteLine("\n Danh sách tên:");
            foreach (var item in names)
            {
                Console.Write("{0,-15}", item);
            }

            Console.WriteLine("\n Danh sách tên:");
            index = 0;
            while(index<names.Length)
            {
                Console.Write("{0,-15}", names[index]);
                index++;
            }

            Console.ReadKey();


        }
    }
}
