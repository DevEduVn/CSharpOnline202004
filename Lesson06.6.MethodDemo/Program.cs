using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06._6.MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng
            Student obj = new Student();
            obj.Input();
            obj.Display();
            Console.WriteLine("Average:" + obj.Average());

            // tính tổng
            int t= obj.Add(123, 123);
            Console.WriteLine("Tổng:" + t);

            obj.Add(123, 123, 123);

            Console.ReadLine();

        }
    }
    /// <summary>
    ///     Student:
    ///     Properties  : RollNo, FullName, Mark1, Mark2, Mark3
    ///     Method      :
    ///                 - Input()   : Nhập thông tin
    ///                 - Display() : Hiển thị thông tin sinh viên
    ///                 - Average() : Trả về điểm trung bình
    ///                 - float Add(float a, float  b) => trả về tổng
    ///                 - void Add(float m1, float m2, float m3) => hiển thị tổng điểm
    ///   10'           
    /// </summary>
    class Student
    {
        // Properties
        public int RollNo { get; set; }
        public string Name { get; set; }
        public float Mark1 { get; set; }
        public float Mark2 { get; set; }
        public float Mark3 { get; set; }

        // Method
        public void Input()
        {
            // Nhập các thông tin
            Console.Write("Roll No.:");
            RollNo = int.Parse(Console.ReadLine());
            Console.Write("Name:");
            Name = Console.ReadLine();
            Console.Write("Mark 1:");
            Mark1 = float.Parse(Console.ReadLine());
            Console.Write("Mark 2:");
            Mark2 = float.Parse(Console.ReadLine());
            Console.Write("Mark 3:");
            Mark3 = float.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("{0,-5}{1,-20}{2,10}{3,10}{4,10}", 
                RollNo, Name, Mark1, Mark2, Mark3);
        }
        // Tính trung bình
        public float Average()
        {
            return (Mark1 + Mark2 + Mark3) / 3;
        }
        //Add: tỉnh tổng
        public int Add(int a, int b)
        {
            return a + b;
        }
        //Add: tính tổng 3 tham số
        public void Add(float m1, float m2, float m3)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", m1, m2, m3, (m1 + m2 + m3));
        }
    }
}
